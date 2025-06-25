namespace vehicle_rental
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Id = new TextBox();
            label8 = new Label();
            Name = new TextBox();
            label7 = new Label();
            Address = new TextBox();
            label14 = new Label();
            Phone = new TextBox();
            label4 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            CusDGV = new DataGridView();
            label9 = new Label();
            label6 = new Label();
            CT = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CusDGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 69, 111);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 845);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 24);
            panel2.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 69, 111);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 125);
            panel1.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1178, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 48);
            label2.TabIndex = 8;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(342, 19);
            label3.Name = "label3";
            label3.Size = new Size(554, 53);
            label3.TabIndex = 2;
            label3.Text = "VEHICLE RENTAL SYSYTEM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(512, 72);
            label5.Name = "label5";
            label5.Size = new Size(247, 44);
            label5.TabIndex = 7;
            label5.Text = "Manage Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(554, 53);
            label1.TabIndex = 2;
            label1.Text = "VEHICLE RENTAL SYSYTEM";
            // 
            // Id
            // 
            Id.BackColor = SystemColors.ButtonFace;
            Id.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            Id.Location = new Point(177, 183);
            Id.Multiline = true;
            Id.Name = "Id";
            Id.Size = new Size(331, 34);
            Id.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(32, 69, 111);
            label8.Location = new Point(23, 183);
            label8.Name = "label8";
            label8.Size = new Size(43, 44);
            label8.TabIndex = 38;
            label8.Text = "ID";
            // 
            // Name
            // 
            Name.BackColor = SystemColors.ButtonFace;
            Name.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            Name.Location = new Point(177, 242);
            Name.Multiline = true;
            Name.Name = "Name";
            Name.Size = new Size(331, 34);
            Name.TabIndex = 41;
            Name.Text = "Customer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(32, 69, 111);
            label7.Location = new Point(23, 242);
            label7.Name = "label7";
            label7.Size = new Size(86, 44);
            label7.TabIndex = 40;
            label7.Text = "Name";
            // 
            // Address
            // 
            Address.BackColor = SystemColors.ButtonFace;
            Address.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            Address.Location = new Point(177, 296);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(331, 34);
            Address.TabIndex = 43;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(32, 69, 111);
            label14.Location = new Point(23, 286);
            label14.Name = "label14";
            label14.Size = new Size(118, 44);
            label14.TabIndex = 42;
            label14.Text = "Address";
            // 
            // Phone
            // 
            Phone.BackColor = SystemColors.ButtonFace;
            Phone.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            Phone.Location = new Point(177, 349);
            Phone.Multiline = true;
            Phone.Name = "Phone";
            Phone.Size = new Size(331, 34);
            Phone.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(32, 69, 111);
            label4.Location = new Point(27, 339);
            label4.Name = "label4";
            label4.Size = new Size(92, 44);
            label4.TabIndex = 52;
            label4.Text = "Phone";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 69, 111);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(285, 764);
            button5.Name = "button5";
            button5.Size = new Size(103, 44);
            button5.TabIndex = 58;
            button5.Text = "CLEAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 69, 111);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(143, 764);
            button4.Name = "button4";
            button4.Size = new Size(103, 44);
            button4.TabIndex = 57;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 69, 111);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(337, 692);
            button3.Name = "button3";
            button3.Size = new Size(117, 43);
            button3.TabIndex = 56;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 69, 111);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(211, 690);
            button2.Name = "button2";
            button2.Size = new Size(103, 44);
            button2.TabIndex = 55;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 69, 111);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(90, 689);
            button1.Name = "button1";
            button1.Size = new Size(101, 43);
            button1.TabIndex = 54;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CusDGV
            // 
            CusDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CusDGV.Location = new Point(560, 206);
            CusDGV.Name = "CusDGV";
            CusDGV.RowHeadersWidth = 51;
            CusDGV.Size = new Size(643, 595);
            CusDGV.TabIndex = 60;
            CusDGV.CellContentClick += CusDGV_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(32, 69, 111);
            label9.Location = new Point(780, 146);
            label9.Name = "label9";
            label9.Size = new Size(196, 44);
            label9.TabIndex = 59;
            label9.Text = "Customers List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(32, 69, 111);
            label6.Location = new Point(27, 411);
            label6.Name = "label6";
            label6.Size = new Size(50, 44);
            label6.TabIndex = 61;
            label6.Text = "CT";
            // 
            // CT
            // 
            CT.BackColor = SystemColors.ButtonFace;
            CT.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            CT.Location = new Point(177, 421);
            CT.Multiline = true;
            CT.Name = "CT";
            CT.Size = new Size(331, 34);
            CT.TabIndex = 62;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 869);
            Controls.Add(CT);
            Controls.Add(label6);
            Controls.Add(CusDGV);
            Controls.Add(label9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Phone);
            Controls.Add(label4);
            Controls.Add(Address);
            Controls.Add(label14);
            Controls.Add(Name);
            Controls.Add(label7);
            Controls.Add(Id);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name.Text = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "some value";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CusDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Id;
        private Label label8;
        private TextBox Name;
        private Label label7;
        private TextBox Address;
        private Label label14;
        private TextBox Phone;
        private Label label4;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView CusDGV;
        private Label label9;
        private Label label6;
        private TextBox CT;
    }
}