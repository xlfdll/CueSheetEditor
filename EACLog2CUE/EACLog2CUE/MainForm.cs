using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace EACLog2CUE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

                if (extension == ".log" || extension == ".txt")
                {
                    processStart(filenames[0]);
                }
                else
                {
                    SetCriticalMessage("No EAC Log Content");
                }
            }
        }

        private void loadEACLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Multiselect = false;
                dlg.CheckFileExists = true;
                dlg.CheckPathExists = true;

                dlg.Title = "Open an Exact Audio Copy Log File";
                dlg.Filter = "EAC Log (*.log)|*.log|Text Document (*.txt)|*.txt|All Files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    processStart(dlg.FileName);
                }
            }
        }

        private void cueTextBox_TextChanged(object sender, EventArgs e)
        {
            saveCUESheetToolStripMenuItem.Enabled = !String.IsNullOrEmpty(cueTextBox.Text);
        }

        private void saveCUESheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save CUE";
                dlg.Filter = "CUE File (*.cue)|*.cue|All Files (*.*)|*.*";
                dlg.OverwritePrompt = true;
                dlg.FileName = fileNameToolStripStatusLabel.Text;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, cueTextBox.Text, Encoding.UTF8);

                    MessageBox.Show("CUE File Save Completed." + Environment.NewLine + Environment.NewLine + dlg.FileName, "Save Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void quitToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processStart(String filename)
        {
            cueTextBox.Clear();

            SetMessage(Path.GetFileNameWithoutExtension(filename));

            processLogData(filename);
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