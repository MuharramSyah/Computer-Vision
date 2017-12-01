namespace Insafgram
{
    partial class VideoForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EyeBtn = new System.Windows.Forms.CheckBox();
            this.NoseBtn = new System.Windows.Forms.CheckBox();
            this.faceBtn = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EyeBtn);
            this.groupBox1.Controls.Add(this.NoseBtn);
            this.groupBox1.Controls.Add(this.faceBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detection Type";
            // 
            // EyeBtn
            // 
            this.EyeBtn.AutoSize = true;
            this.EyeBtn.Location = new System.Drawing.Point(346, 31);
            this.EyeBtn.Name = "EyeBtn";
            this.EyeBtn.Size = new System.Drawing.Size(44, 17);
            this.EyeBtn.TabIndex = 0;
            this.EyeBtn.Text = "Eye";
            this.EyeBtn.UseVisualStyleBackColor = true;
            this.EyeBtn.CheckedChanged += new System.EventHandler(this.EyeBtn_CheckedChanged);
            // 
            // NoseBtn
            // 
            this.NoseBtn.AutoSize = true;
            this.NoseBtn.Location = new System.Drawing.Point(233, 31);
            this.NoseBtn.Name = "NoseBtn";
            this.NoseBtn.Size = new System.Drawing.Size(51, 17);
            this.NoseBtn.TabIndex = 0;
            this.NoseBtn.Text = "Nose";
            this.NoseBtn.UseVisualStyleBackColor = true;
            this.NoseBtn.CheckedChanged += new System.EventHandler(this.NoseBtn_CheckedChanged);
            // 
            // faceBtn
            // 
            this.faceBtn.AutoSize = true;
            this.faceBtn.Location = new System.Drawing.Point(113, 31);
            this.faceBtn.Name = "faceBtn";
            this.faceBtn.Size = new System.Drawing.Size(50, 17);
            this.faceBtn.TabIndex = 0;
            this.faceBtn.Text = "Face";
            this.faceBtn.UseVisualStyleBackColor = true;
            this.faceBtn.CheckedChanged += new System.EventHandler(this.faceBtn_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VideoForm";
            this.Text = "VideoForm";
            this.Load += new System.EventHandler(this.VideoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox EyeBtn;
        private System.Windows.Forms.CheckBox NoseBtn;
        private System.Windows.Forms.CheckBox faceBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}