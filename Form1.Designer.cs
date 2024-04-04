namespace ytdlp_gui_mp3
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
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.labelURLText = new System.Windows.Forms.Label();
            this.textBoxConsoleOutput = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogDownloadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.Location = new System.Drawing.Point(669, 176);
            this.buttonDownload.MaximumSize = new System.Drawing.Size(85, 40);
            this.buttonDownload.MinimumSize = new System.Drawing.Size(85, 40);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Padding = new System.Windows.Forms.Padding(3);
            this.buttonDownload.Size = new System.Drawing.Size(85, 40);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxURL.Location = new System.Drawing.Point(6, 38);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(748, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.labelFolderPath);
            this.groupBoxMain.Controls.Add(this.buttonDownload);
            this.groupBoxMain.Controls.Add(this.buttonFolder);
            this.groupBoxMain.Controls.Add(this.textBoxURL);
            this.groupBoxMain.Controls.Add(this.labelURLText);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(760, 222);
            this.groupBoxMain.TabIndex = 3;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Parameters";
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(112, 78);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(22, 13);
            this.labelFolderPath.TabIndex = 5;
            this.labelFolderPath.Text = "C:\\";
            // 
            // buttonFolder
            // 
            this.buttonFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFolder.Location = new System.Drawing.Point(6, 64);
            this.buttonFolder.MaximumSize = new System.Drawing.Size(100, 40);
            this.buttonFolder.MinimumSize = new System.Drawing.Size(100, 40);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(100, 40);
            this.buttonFolder.TabIndex = 2;
            this.buttonFolder.Text = "Select Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // labelURLText
            // 
            this.labelURLText.AutoSize = true;
            this.labelURLText.Location = new System.Drawing.Point(3, 16);
            this.labelURLText.Name = "labelURLText";
            this.labelURLText.Padding = new System.Windows.Forms.Padding(3);
            this.labelURLText.Size = new System.Drawing.Size(35, 19);
            this.labelURLText.TabIndex = 3;
            this.labelURLText.Text = "URL";
            // 
            // textBoxConsoleOutput
            // 
            this.textBoxConsoleOutput.AcceptsReturn = true;
            this.textBoxConsoleOutput.AcceptsTab = true;
            this.textBoxConsoleOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConsoleOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxConsoleOutput.Enabled = false;
            this.textBoxConsoleOutput.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxConsoleOutput.HideSelection = false;
            this.textBoxConsoleOutput.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxConsoleOutput.Location = new System.Drawing.Point(0, 240);
            this.textBoxConsoleOutput.MinimumSize = new System.Drawing.Size(784, 166);
            this.textBoxConsoleOutput.Multiline = true;
            this.textBoxConsoleOutput.Name = "textBoxConsoleOutput";
            this.textBoxConsoleOutput.ReadOnly = true;
            this.textBoxConsoleOutput.Size = new System.Drawing.Size(784, 171);
            this.textBoxConsoleOutput.TabIndex = 2;
            this.textBoxConsoleOutput.Text = "Output: ";
            // 
            // folderBrowserDialogDownloadLocation
            // 
            this.folderBrowserDialogDownloadLocation.Description = "Select Folder";
            this.folderBrowserDialogDownloadLocation.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogDownloadLocation.SelectedPath = "C:\\";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(784, 411);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.textBoxConsoleOutput);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube MP3 Downloader";
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.TextBox textBoxConsoleOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDownloadLocation;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelURLText;
        private System.Windows.Forms.Label labelFolderPath;
    }
}

