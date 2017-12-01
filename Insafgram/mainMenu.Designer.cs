namespace Insafgram
{
    partial class mainMenu
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
            this.browseImage = new System.Windows.Forms.Button();
            this.captureImage = new System.Windows.Forms.Button();
            this.browseVideo = new System.Windows.Forms.Button();
            this.signOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.openVideo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // browseImage
            // 
            this.browseImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseImage.Location = new System.Drawing.Point(98, 73);
            this.browseImage.Name = "browseImage";
            this.browseImage.Size = new System.Drawing.Size(138, 47);
            this.browseImage.TabIndex = 0;
            this.browseImage.Text = "Browse Image";
            this.browseImage.UseVisualStyleBackColor = false;
            this.browseImage.Click += new System.EventHandler(this.browseImage_Click);
            // 
            // captureImage
            // 
            this.captureImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captureImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.captureImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureImage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.captureImage.Location = new System.Drawing.Point(98, 126);
            this.captureImage.Name = "captureImage";
            this.captureImage.Size = new System.Drawing.Size(138, 47);
            this.captureImage.TabIndex = 0;
            this.captureImage.Text = "Capture Image";
            this.captureImage.UseVisualStyleBackColor = false;
            this.captureImage.Click += new System.EventHandler(this.captureImage_Click);
            // 
            // browseVideo
            // 
            this.browseVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.browseVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseVideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.browseVideo.Location = new System.Drawing.Point(98, 179);
            this.browseVideo.Name = "browseVideo";
            this.browseVideo.Size = new System.Drawing.Size(138, 47);
            this.browseVideo.TabIndex = 0;
            this.browseVideo.Text = "Browse Video";
            this.browseVideo.UseVisualStyleBackColor = false;
            this.browseVideo.Click += new System.EventHandler(this.browseVideo_Click);
            // 
            // signOut
            // 
            this.signOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signOut.Location = new System.Drawing.Point(98, 267);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(138, 47);
            this.signOut.TabIndex = 0;
            this.signOut.Text = "Sing Out";
            this.signOut.UseVisualStyleBackColor = false;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(121, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            // 
            // openVideo
            // 
            this.openVideo.FileName = "openFileDialog1";
            this.openVideo.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(329, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.browseVideo);
            this.Controls.Add(this.captureImage);
            this.Controls.Add(this.browseImage);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsafGram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseImage;
        private System.Windows.Forms.Button captureImage;
        private System.Windows.Forms.Button browseVideo;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.OpenFileDialog openVideo;
    }
}