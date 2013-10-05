namespace PhotoDescription.Popups
{
    partial class NewTripForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PathText = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.PathPickerButton = new System.Windows.Forms.Button();
            this.PictureCountLabel = new System.Windows.Forms.Label();
            this.TripTitleText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TripDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trip Name:";
            // 
            // PathText
            // 
            this.PathText.Enabled = false;
            this.PathText.Location = new System.Drawing.Point(81, 48);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(463, 20);
            this.PathText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Photo Count:";
            // 
            // PathPickerButton
            // 
            this.PathPickerButton.Location = new System.Drawing.Point(12, 13);
            this.PathPickerButton.Name = "PathPickerButton";
            this.PathPickerButton.Size = new System.Drawing.Size(75, 23);
            this.PathPickerButton.TabIndex = 3;
            this.PathPickerButton.Text = "Browse";
            this.PathPickerButton.UseVisualStyleBackColor = true;
            this.PathPickerButton.Click += new System.EventHandler(this.PathPickerButton_Click);
            // 
            // PictureCountLabel
            // 
            this.PictureCountLabel.AutoSize = true;
            this.PictureCountLabel.Location = new System.Drawing.Point(78, 73);
            this.PictureCountLabel.Name = "PictureCountLabel";
            this.PictureCountLabel.Size = new System.Drawing.Size(0, 13);
            this.PictureCountLabel.TabIndex = 4;
            // 
            // TripTitleText
            // 
            this.TripTitleText.Location = new System.Drawing.Point(81, 92);
            this.TripTitleText.Name = "TripTitleText";
            this.TripTitleText.Size = new System.Drawing.Size(240, 20);
            this.TripTitleText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path:";
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 148);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 7;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(93, 148);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TripDescription
            // 
            this.TripDescription.Location = new System.Drawing.Point(81, 118);
            this.TripDescription.Name = "TripDescription";
            this.TripDescription.Size = new System.Drawing.Size(463, 20);
            this.TripDescription.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // NewTripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 181);
            this.Controls.Add(this.TripDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TripTitleText);
            this.Controls.Add(this.PictureCountLabel);
            this.Controls.Add(this.PathPickerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.label1);
            this.Name = "NewTripForm";
            this.Text = "NewTripForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PathPickerButton;
        private System.Windows.Forms.Label PictureCountLabel;
        private System.Windows.Forms.TextBox TripTitleText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox TripDescription;
        private System.Windows.Forms.Label label4;
    }
}