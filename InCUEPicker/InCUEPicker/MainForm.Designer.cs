namespace InCUEPicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.loadButton = new System.Windows.Forms.Button();
            this.cueTextBox = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cueTextLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.startGroupBox = new System.Windows.Forms.GroupBox();
            this.audioRadioButton = new System.Windows.Forms.RadioButton();
            this.eacLogRadioButton = new System.Windows.Forms.RadioButton();
            this.encodingLabel = new System.Windows.Forms.Label();
            this.encodingComboBox = new System.Windows.Forms.ComboBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fileNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.startGroupBox.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.Name = "loadButton";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // cueTextBox
            // 
            resources.ApplyResources(this.cueTextBox, "cueTextBox");
            this.cueTextBox.Name = "cueTextBox";
            this.cueTextBox.TextChanged += new System.EventHandler(this.cueTextBox_TextChanged);
            // 
            // quitButton
            // 
            resources.ApplyResources(this.quitButton, "quitButton");
            this.quitButton.Name = "quitButton";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoEllipsis = true;
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cueTextLabel
            // 
            resources.ApplyResources(this.cueTextLabel, "cueTextLabel");
            this.cueTextLabel.Name = "cueTextLabel";
            // 
            // copyrightLabel
            // 
            resources.ApplyResources(this.copyrightLabel, "copyrightLabel");
            this.copyrightLabel.Name = "copyrightLabel";
            // 
            // startGroupBox
            // 
            this.startGroupBox.Controls.Add(this.audioRadioButton);
            this.startGroupBox.Controls.Add(this.eacLogRadioButton);
            resources.ApplyResources(this.startGroupBox, "startGroupBox");
            this.startGroupBox.Name = "startGroupBox";
            this.startGroupBox.TabStop = false;
            // 
            // audioRadioButton
            // 
            resources.ApplyResources(this.audioRadioButton, "audioRadioButton");
            this.audioRadioButton.Name = "audioRadioButton";
            this.audioRadioButton.UseVisualStyleBackColor = true;
            // 
            // eacLogRadioButton
            // 
            resources.ApplyResources(this.eacLogRadioButton, "eacLogRadioButton");
            this.eacLogRadioButton.Checked = true;
            this.eacLogRadioButton.Name = "eacLogRadioButton";
            this.eacLogRadioButton.TabStop = true;
            this.eacLogRadioButton.UseVisualStyleBackColor = true;
            // 
            // encodingLabel
            // 
            resources.ApplyResources(this.encodingLabel, "encodingLabel");
            this.encodingLabel.Name = "encodingLabel";
            // 
            // encodingComboBox
            // 
            this.encodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingComboBox.FormattingEnabled = true;
            this.encodingComboBox.Items.AddRange(new object[] {
            resources.GetString("encodingComboBox.Items"),
            resources.GetString("encodingComboBox.Items1"),
            resources.GetString("encodingComboBox.Items2"),
            resources.GetString("encodingComboBox.Items3"),
            resources.GetString("encodingComboBox.Items4")});
            resources.ApplyResources(this.encodingComboBox, "encodingComboBox");
            this.encodingComboBox.Name = "encodingComboBox";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNameToolStripStatusLabel});
            resources.ApplyResources(this.mainStatusStrip, "mainStatusStrip");
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.ShowItemToolTips = true;
            this.mainStatusStrip.SizingGrip = false;
            // 
            // fileNameToolStripStatusLabel
            // 
            resources.ApplyResources(this.fileNameToolStripStatusLabel, "fileNameToolStripStatusLabel");
            this.fileNameToolStripStatusLabel.AutoToolTip = true;
            this.fileNameToolStripStatusLabel.Name = "fileNameToolStripStatusLabel";
            this.fileNameToolStripStatusLabel.Spring = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.encodingComboBox);
            this.Controls.Add(this.encodingLabel);
            this.Controls.Add(this.startGroupBox);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.cueTextLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.cueTextBox);
            this.Controls.Add(this.loadButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.startGroupBox.ResumeLayout(false);
            this.startGroupBox.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox cueTextBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label cueTextLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.GroupBox startGroupBox;
        private System.Windows.Forms.RadioButton audioRadioButton;
        private System.Windows.Forms.RadioButton eacLogRadioButton;
        private System.Windows.Forms.Label encodingLabel;
        private System.Windows.Forms.ComboBox encodingComboBox;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel fileNameToolStripStatusLabel;
    }
}

