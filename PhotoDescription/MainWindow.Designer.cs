using System.Windows.Forms;

namespace PhotoDescription
{
    partial class MainWindow
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePictureDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PhotoDisplay = new System.Windows.Forms.PictureBox();
            this.PhotoPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhotoDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhotoCount = new System.Windows.Forms.Label();
            this.PictureIndex = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(576, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTripToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTripToolStripMenuItem
            // 
            this.newTripToolStripMenuItem.Name = "newTripToolStripMenuItem";
            this.newTripToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.newTripToolStripMenuItem.Text = "New Trip";
            this.newTripToolStripMenuItem.Click += new System.EventHandler(this.newTripToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl - S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.ShowShortcutKeys = false;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadToolStripMenuItem.Text = "Load Trip";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.recentToolStripMenuItem.Text = "Recent Trips";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadPicturesToolStripMenuItem,
            this.changePictureDirectoryToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.otherToolStripMenuItem.Text = "Phase 2";
            // 
            // reloadPicturesToolStripMenuItem
            // 
            this.reloadPicturesToolStripMenuItem.Name = "reloadPicturesToolStripMenuItem";
            this.reloadPicturesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.reloadPicturesToolStripMenuItem.Text = "Reload Pictures";
            // 
            // changePictureDirectoryToolStripMenuItem
            // 
            this.changePictureDirectoryToolStripMenuItem.Name = "changePictureDirectoryToolStripMenuItem";
            this.changePictureDirectoryToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.changePictureDirectoryToolStripMenuItem.Text = "Change Picture Directory";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PhotoDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PhotoPath);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.PhotoDescription);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.PhotoCount);
            this.splitContainer1.Panel2.Controls.Add(this.PictureIndex);
            this.splitContainer1.Panel2.Controls.Add(this.NextButton);
            this.splitContainer1.Panel2.Controls.Add(this.PreviousButton);
            this.splitContainer1.Size = new System.Drawing.Size(576, 347);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 1;
            // 
            // PhotoDisplay
            // 
            this.PhotoDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoDisplay.Location = new System.Drawing.Point(0, 0);
            this.PhotoDisplay.Name = "PhotoDisplay";
            this.PhotoDisplay.Size = new System.Drawing.Size(576, 255);
            this.PhotoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoDisplay.TabIndex = 0;
            this.PhotoDisplay.TabStop = false;
            // 
            // PhotoPath
            // 
            this.PhotoPath.Enabled = false;
            this.PhotoPath.Location = new System.Drawing.Point(84, 30);
            this.PhotoPath.Name = "PhotoPath";
            this.PhotoPath.Size = new System.Drawing.Size(480, 20);
            this.PhotoPath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path:";
            // 
            // PhotoDescription
            // 
            this.PhotoDescription.Location = new System.Drawing.Point(83, 6);
            this.PhotoDescription.Name = "PhotoDescription";
            this.PhotoDescription.Size = new System.Drawing.Size(481, 20);
            this.PhotoDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // PhotoCount
            // 
            this.PhotoCount.AutoSize = true;
            this.PhotoCount.Location = new System.Drawing.Point(217, 59);
            this.PhotoCount.Name = "PhotoCount";
            this.PhotoCount.Size = new System.Drawing.Size(42, 13);
            this.PhotoCount.TabIndex = 3;
            this.PhotoCount.Text = "42 / 34";
            // 
            // PictureIndex
            // 
            this.PictureIndex.Location = new System.Drawing.Point(174, 56);
            this.PictureIndex.Name = "PictureIndex";
            this.PictureIndex.Size = new System.Drawing.Size(37, 20);
            this.PictureIndex.TabIndex = 2;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(93, 54);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(12, 54);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 0;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 371);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainWindow";
            this.Text = "Photo Description 2.0";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadPicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePictureDirectoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox PhotoDisplay;
        private System.Windows.Forms.TextBox PhotoDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PhotoCount;
        private System.Windows.Forms.TextBox PictureIndex;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem newTripToolStripMenuItem;
        private System.Windows.Forms.TextBox PhotoPath;
        private System.Windows.Forms.Label label1;
    }
}

