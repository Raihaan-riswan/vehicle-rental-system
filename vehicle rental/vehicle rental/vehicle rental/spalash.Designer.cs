namespace vehicle_rental
{
    partial class spalash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spalash));
            myPic = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            myProgress = new ProgressBar();
            Percentage = new Label();
            ((System.ComponentModel.ISupportInitialize)myPic).BeginInit();
            SuspendLayout();
            // 
            // myPic
            // 
            myPic.Image = (Image)resources.GetObject("myPic.Image");
            myPic.Location = new Point(203, 120);
            myPic.Name = "myPic";
            myPic.Size = new Size(358, 229);
            myPic.SizeMode = PictureBoxSizeMode.Zoom;
            myPic.TabIndex = 0;
            myPic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(26, 47, 78);
            label1.Location = new Point(126, 21);
            label1.Name = "label1";
            label1.Size = new Size(554, 53);
            label1.TabIndex = 1;
            label1.Text = "VEHICLE RENTAL SYSYTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(32, 69, 111);
            label2.Location = new Point(336, 431);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 2;
            label2.Text = "Group 04";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // myProgress
            // 
            myProgress.BackColor = SystemColors.ControlDarkDark;
            myProgress.ForeColor = Color.FromArgb(0, 0, 64);
            myProgress.Location = new Point(203, 368);
            myProgress.Name = "myProgress";
            myProgress.Size = new Size(358, 10);
            myProgress.TabIndex = 3;
            myProgress.Click += myProgress_Click;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Bernard MT Condensed", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Percentage.ForeColor = Color.FromArgb(32, 69, 111);
            Percentage.Location = new Point(360, 381);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(124, 33);
            Percentage.TabIndex = 4;
            Percentage.Text = "Group 04";
            // 
            // spalash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(810, 500);
            Controls.Add(Percentage);
            Controls.Add(myProgress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(myPic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "spalash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += spalash_Load;
            ((System.ComponentModel.ISupportInitialize)myPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox myPic;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar myProgress;
        private Label Percentage;
    }
}
