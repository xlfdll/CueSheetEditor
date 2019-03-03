namespace EACLog2CUE
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
            this.cueTextBox = new System.Windows.Forms.TextBox();
            this.cueTextLabel = new System.Windows.Forms.Label();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fileNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.operationToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.loadEACLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCUESheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.quitToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cueTextBox
            // 
            resources.ApplyResources(this.cueTextBox, "cueTextBox");
            this.cueTextBox.Name = "cueTextBox";
            this.cueTextBox.TextChanged += new System.EventHandler(this.cueTextBox_TextChanged);
            // 
            // cueTextLabel
            // 
            resources.ApplyResources(this.cueTextLabel, "cueTextLabel");
            this.cueTextLabel.Name = "cueTextLabel";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNameToolStripStatusLabel,
            this.operationToolStripSplitButton,
            this.copyrightToolStripStatusLabel,
            this.quitToolStripStatusLabel});
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
            // operationToolStripSplitButton
            // 
            this.operationToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.operationToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadEACLogToolStripMenuItem,
            this.saveCUESheetToolStripMenuItem});
            resources.ApplyResources(this.operationToolStripSplitButton, "operationToolStripSplitButton");
            this.operationToolStripSplitButton.Name = "operationToolStripSplitButton";
            // 
            // loadEACLogToolStripMenuItem
            // 
            this.loadEACLogToolStripMenuItem.AutoToolTip = true;
            this.loadEACLogToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadEACLogToolStripMenuItem.Name = "loadEACLogToolStripMenuItem";
            resources.ApplyResources(this.loadEACLogToolStripMenuItem, "loadEACLogToolStripMenuItem");
            this.loadEACLogToolStripMenuItem.Click += new System.EventHandler(this.loadEACLogToolStripMenuItem_Click);
            // 
            // saveCUESheetToolStripMenuItem
            // 
            this.saveCUESheetToolStripMenuItem.AutoToolTip = true;
            this.saveCUESheetToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveCUESheetToolStripMenuItem.Name = "saveCUESheetToolStripMenuItem";
            resources.ApplyResources(this.saveCUESheetToolStripMenuItem, "saveCUESheetToolStripMenuItem");
            this.saveCUESheetToolStripMenuItem.Click += new System.EventHandler(this.saveCUESheetToolStripMenuItem_Click);
            // 
            // copyrightToolStripStatusLabel
            // 
            this.copyrightToolStripStatusLabel.Name = "copyrightToolStripStatusLabel";
            resources.ApplyResources(this.copyrightToolStripStatusLabel, "copyrightToolStripStatusLabel");
            // 
            // quitToolStripStatusLabel
            // 
            this.quitToolStripStatusLabel.IsLink = true;
            this.quitToolStripStatusLabel.Name = "quitToolStripStatusLabel";
            resources.ApplyResources(this.quitToolStripStatusLabel, "quitToolStripStatusLabel");
            this.quitToolStripStatusLabel.Click += new System.EventHandler(this.quitToolStripStatusLabel_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.cueTextLabel);
            this.Controls.Add(this.cueTextBox);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cueTextBox;
        private System.Windows.Forms.Label cueTextLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel fileNameToolStripStatusLabel;
        private System.Windows.Forms.ToolStripSplitButton operationToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem loadEACLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCUESheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel copyrightToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel quitToolStripStatusLabel;
    }
}

