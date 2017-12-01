namespace Insafgram
{
    partial class filter
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("original");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Grayscale");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Blur");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Gaussian");
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Adjustment = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aperture = new System.Windows.Forms.NumericUpDown();
            this.Brightness = new System.Windows.Forms.NumericUpDown();
            this.Thresshold = new System.Windows.Forms.NumericUpDown();
            this.shapeDetection = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.effect1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.effect2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.effect3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.effect4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Adjustment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aperture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thresshold)).BeginInit();
            this.shapeDetection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(149, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSAFGRAM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Adjustment
            // 
            this.Adjustment.Controls.Add(this.label4);
            this.Adjustment.Controls.Add(this.label3);
            this.Adjustment.Controls.Add(this.label2);
            this.Adjustment.Controls.Add(this.aperture);
            this.Adjustment.Controls.Add(this.Brightness);
            this.Adjustment.Controls.Add(this.Thresshold);
            this.Adjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adjustment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adjustment.Location = new System.Drawing.Point(256, 89);
            this.Adjustment.Name = "Adjustment";
            this.Adjustment.Size = new System.Drawing.Size(190, 121);
            this.Adjustment.TabIndex = 2;
            this.Adjustment.TabStop = false;
            this.Adjustment.Text = "Adjustment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aperture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Low Thres";
            // 
            // aperture
            // 
            this.aperture.Location = new System.Drawing.Point(111, 89);
            this.aperture.Name = "aperture";
            this.aperture.Size = new System.Drawing.Size(73, 20);
            this.aperture.TabIndex = 6;
            // 
            // Brightness
            // 
            this.Brightness.Location = new System.Drawing.Point(111, 54);
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(73, 20);
            this.Brightness.TabIndex = 6;
            // 
            // Thresshold
            // 
            this.Thresshold.Location = new System.Drawing.Point(111, 19);
            this.Thresshold.Name = "Thresshold";
            this.Thresshold.Size = new System.Drawing.Size(73, 20);
            this.Thresshold.TabIndex = 6;
            // 
            // shapeDetection
            // 
            this.shapeDetection.Controls.Add(this.radioButton3);
            this.shapeDetection.Controls.Add(this.radioButton2);
            this.shapeDetection.Controls.Add(this.radioButton1);
            this.shapeDetection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shapeDetection.Location = new System.Drawing.Point(256, 216);
            this.shapeDetection.Name = "shapeDetection";
            this.shapeDetection.Size = new System.Drawing.Size(190, 59);
            this.shapeDetection.TabIndex = 3;
            this.shapeDetection.TabStop = false;
            this.shapeDetection.Text = "Shape Detection";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(133, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Circle";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(59, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rectangle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Line";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(315, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(20, 20);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.effect1,
            this.effect2,
            this.effect3,
            this.effect4});
            listViewItem1.UseItemStyleForSubItems = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(19, 310);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(427, 142);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // effect1
            // 
            this.effect1.Width = 100;
            // 
            // effect2
            // 
            this.effect2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.effect2.Width = 100;
            // 
            // effect3
            // 
            this.effect3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.effect3.Width = 100;
            // 
            // effect4
            // 
            this.effect4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.effect4.Width = 100;
            // 
            // filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(467, 464);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeDetection);
            this.Controls.Add(this.Adjustment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsafGram";
            this.Load += new System.EventHandler(this.filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Adjustment.ResumeLayout(false);
            this.Adjustment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aperture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thresshold)).EndInit();
            this.shapeDetection.ResumeLayout(false);
            this.shapeDetection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Adjustment;
        private System.Windows.Forms.GroupBox shapeDetection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown aperture;
        private System.Windows.Forms.NumericUpDown Brightness;
        private System.Windows.Forms.NumericUpDown Thresshold;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader effect1;
        private System.Windows.Forms.ColumnHeader effect2;
        private System.Windows.Forms.ColumnHeader effect3;
        private System.Windows.Forms.ColumnHeader effect4;
    }
}