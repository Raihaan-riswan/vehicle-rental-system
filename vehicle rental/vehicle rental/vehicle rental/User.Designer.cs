
namespace vehicle_rental
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Upass = new TextBox();
            label9 = new Label();
            label14 = new Label();
            label8 = new Label();
            Uid = new TextBox();
            label7 = new Label();
            Uname = new TextBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            UserDGV = new DataGridView();
            panel2 = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1166, 21);
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
            label5.Size = new Size(189, 44);
            label5.TabIndex = 7;
            label5.Text = "Manage Users";
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
            // Upass
            // 
            Upass.BackColor = SystemColors.ButtonFace;
            Upass.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            Upass.Location = new Point(161, 315);
            Upass.Multiline = true;
            Upass.Name = "Upass";
            Upass.Size = new Size(310, 34);
            Upass.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(32, 69, 111);
            label9.Location = new Point(808, 144);
            label9.Name = "label9";
            label9.Size = new Size(138, 44);
            label9.TabIndex = 14;
            label9.Text = "Users List";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(32, 69, 111);
            label14.Location = new Point(12, 305);
            label14.Name = "label14";
            label14.Size = new Size(139, 44);
            label14.TabIndex = 16;
            label14.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(32, 69, 111);
            label8.Location = new Point(55, 203);
            label8.Name = "label8";
            label8.Size = new Size(43, 44);
            label8.TabIndex = 20;
            label8.Text = "ID";
            // 
            // Uid
            // 
            Uid.BackColor = SystemColors.ButtonFace;
            Uid.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            Uid.Location = new Point(161, 206);
            Uid.Multiline = true;
            Uid.Name = "Uid";
            Uid.Size = new Size(310, 34);
            Uid.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(32, 69, 111);
            label7.Location = new Point(22, 261);
            label7.Name = "label7";
            label7.Size = new Size(86, 44);
            label7.TabIndex = 15;
            label7.Text = "Name";
            // 
            // Uname
            // 
            Uname.BackColor = SystemColors.ButtonFace;
            Uname.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            Uname.Location = new Point(161, 261);
            Uname.Multiline = true;
            Uname.Name = "Uname";
            Uname.Size = new Size(310, 34);
            Uname.TabIndex = 17;
            Uname.TextChanged += Uname_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 69, 111);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(319, 397);
            button3.Name = "button3";
            button3.Size = new Size(117, 43);
            button3.TabIndex = 26;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 69, 111);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(67, 397);
            button1.Name = "button1";
            button1.Size = new Size(101, 43);
            button1.TabIndex = 24;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(32, 69, 111);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(191, 397);
            button2.Name = "button2";
            button2.Size = new Size(103, 44);
            button2.TabIndex = 25;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 69, 111);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(136, 464);
            button4.Name = "button4";
            button4.Size = new Size(103, 44);
            button4.TabIndex = 27;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UserDGV
            // 
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDGV.Location = new Point(690, 203);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersWidth = 51;
            UserDGV.Size = new Size(420, 595);
            UserDGV.TabIndex = 28;
            UserDGV.CellClick += UserDGV_CellClick_1;
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 69, 111);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 845);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 24);
            panel2.TabIndex = 29;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 69, 111);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(269, 464);
            button5.Name = "button5";
            button5.Size = new Size(103, 44);
            button5.TabIndex = 30;
            button5.Text = "CLEAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 869);
            Controls.Add(button5);
            Controls.Add(panel2);
            Controls.Add(UserDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Uid);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(Uname);
            Controls.Add(Upass);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox Upass;
        private Label label9;
        private Label label14;
        private Label label8;
        private TextBox Uid;
        private Label label7;
        private TextBox Uname;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private DataGridView UserDGV;
        private Panel panel2;
        private Button button5;
    }
}