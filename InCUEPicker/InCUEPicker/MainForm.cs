using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace InCUEPicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            encodingComboBox.SelectedIndex = 1;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            String[] filenames = e.Data.GetData(DataFormats.FileDrop) as String[];

            if (filenames != null && filenames.Length > 0)
            {
                String extension = Path.GetExtension(filenames[0]).ToLowerInvariant();

                switch (extension)
                {
                    case ".log":
                        eacLogRadioButton.Checked = true;
                        processStart(filenames[0]);
                        break;
                    case ".txt":
                        eacLogRadioButton.Checked = true;
                        processStart(filenames[0]);
                        break;
                    case ".tak":
                        audioRadioButton.Checked = true;
                        processStart(filenames[0]);
                        break;
                    default: SetCriticalMessage("No EAC Log or TAK Audio Content");
                        break;
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = false;
                dlg.CheckFileExists = true;
                dlg.CheckPathExists = true;

                if (eacLogRadioButton.Checked)
                {
                    dlg.Title = "Open an Exact Audio Copy Log File";
                    dlg.Filter = "EAC Log (*.log)|*.log|Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
                }
                else if (audioRadioButton.Checked)
                {
                    dlg.Title = "Open a TAK Lossless Audio File";
                    dlg.Filter = "TAK Audio (*.tak)|*.tak|All Files (*.*)|*.*";
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    processStart(dlg.FileName);
                }
            }
        }

        private void cueTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = !String.IsNullOrEmpty(cueTextBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save CUE";
                dlg.Filter = "CUE File (*.cue)|*.cue|All Files (*.*)|*.*";
                dlg.OverwritePrompt = true;
                dlg.FileName = fileNameToolStripStatusLabel.Text;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Encoding encoding;

                    switch (encodingComboBox.SelectedItem.ToString())
                    {
                        case "Default (ANSI)": encoding = Encoding.Default;
                            break;
                        case "UTF-8": encoding = Encoding.UTF8;
                            break;
                        case "Shift-JIS": encoding = Encoding.GetEncoding(932);
                            break;
                        case "GB2312": encoding = Encoding.GetEncoding(936);
                            break;
                        case "Big5": encoding = Encoding.GetEncoding(950);
                            break;
                        default: encoding = Encoding.UTF8;
                            break;
                    }

                    File.WriteAllText(dlg.FileName, cueTextBox.Text, encoding);

                    MessageBox.Show("CUE File Save Completed." + Environment.NewLine + Environment.NewLine + dlg.FileName, "Save Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processStart(String filename)
        {
            cueTextBox.Clear();

            SetMessage(Path.GetFileNameWithoutExtension(filename));

            if (eacLogRadioButton.Checked)
            {
                processLogData(filename);
            }
            else if (audioRadioButton.Checked)
            {
                processAudioData(filename);
            }
        }

        private void processLogData(String filename)
        {
            String data = File.ReadAllText(filename);
            Int32 track = 1;

            MatchCollection timeMatches = Regex.Matches(data, eacLogRegexPattern, RegexOptions.Compiled);

            if (timeMatches.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(@"FILE ""{0}.wav"" WAVE", Path.GetFileNameWithoutExtension(filename));
                sb.AppendLine();

                StringBuilder timesb = new StringBuilder();

                foreach (Match match in timeMatches)
                {
                    timesb.Append(match.Groups["time"].Value);
                    timesb.Replace(".", ":");

                    if (timesb[1] == ':')
                    {
                        timesb.Insert(0, 0);
                    }

                    sb.AppendFormat("  TRACK {0} AUDIO", track.ToString("D2"));
                    sb.AppendLine();
                    track++;
                    sb.AppendFormat("    INDEX 01 {0}", timesb.ToString());
                    sb.AppendLine();

                    timesb.Remove(0, timesb.Length);
                }

                cueTextBox.Text = sb.ToString();
            }
            else
            {
                SetCriticalMessage("No TOC information");
            }
        }

        private void processAudioData(String filename)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Byte[] data = new Byte[8192];
                Int64 a = stream.Seek(-8192, SeekOrigin.End);
                Int32 b = stream.Read(data, 0, 8192 - 32);

                String result = Encoding.UTF8.GetString(data);

                Int32 start = result.IndexOf("Cuesheet", StringComparison.CurrentCultureIgnoreCase) + 9;

                if (start != 8)
                {
                    result = result.Substring(start);
                    Int32 end = result.LastIndexOf(Environment.NewLine);
                    StringBuilder sb = new StringBuilder(result);

                    if (end > 0)
                    {
                        sb.Remove(end + Environment.NewLine.Length, sb.Length - end - Environment.NewLine.Length);
                    }

                    cueTextBox.Text = sb.ToString();
                }
                else
                {
                    SetCriticalMessage("No InCUE Sheet");
                }
            }
        }

        private void SetMessage(String message)
        {
            fileNameToolStripStatusLabel.ForeColor = SystemColors.ControlText;
            fileNameToolStripStatusLabel.BackColor = SystemColors.Control;
            fileNameToolStripStatusLabel.Text = message;
        }

        private void SetCriticalMessage(String message)
        {
            fileNameToolStripStatusLabel.ForeColor = SystemColors.HighlightText;
            fileNameToolStripStatusLabel.BackColor = SystemColors.Highlight;
            fileNameToolStripStatusLabel.Text = message;
        }

        private static readonly String eacLogRegexPattern = @"\s*\d{1,2}\s*\|\s*(?<time>\d{1,3}:\d{1,2}.\d{1,2})\s*";
    }
}