namespace vehicle_rental
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
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 69, 111);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(781, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 48);
            label2.TabIndex = 8;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(325, 71);
            label5.Name = "label5";
            label5.Size = new Size(142, 44);
            label5.TabIndex = 7;
            label5.Text = "Main Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(554, 53);
            label1.TabIndex = 2;
            label1.Text = "VEHICLE RENTAL SYSYTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(722, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 69, 111);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(108, 142);
            button1.Name = "button1";
            button1.Size = new Size(101, 43);
            button1.TabIndex = 3;
            button1.Text = "Vehicle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 69, 111);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(238, 141);
            button2.Name = "button2";
            button2.Size = new Size(103, 44);
            button2.TabIndex = 4;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 69, 111);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(366, 141);
            button3.Name = "button3";
            button3.Size = new Size(101, 43);
            button3.TabIndex = 5;
            button3.Text = "Rental";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 69, 111);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(495, 142);
            button4.Name = "button4";
            button4.Size = new Size(101, 43);
            button4.TabIndex = 6;
            button4.Text = "Return";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 69, 111);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(622, 142);
            button5.Name = "button5";
            button5.Size = new Size(101, 43);
            button5.TabIndex = 7;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 69, 111);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 682);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 24);
            panel2.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(32, 69, 111);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(342, 617);
            button6.Name = "button6";
            button6.Size = new Size(135, 43);
            button6.TabIndex = 9;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(22, 447);
            button7.Name = "button7";
            button7.Size = new Size(8, 8);
            button7.TabIndex = 10;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 706);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(panel2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel2;
        private Label label2;
        private Button button6;
        private Button button7;
    }
}