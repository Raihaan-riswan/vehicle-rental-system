
namespace vehicle_rental
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            RegNumTb = new TextBox();
            label8 = new Label();
            label14 = new Label();
            label7 = new Label();
            CarDGV = new DataGridView();
            label9 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            PriceTb = new TextBox();
            AvailableCb = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ModelTb = new ComboBox();
            label10 = new Label();
            Brandcmb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarDGV).BeginInit();
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
            panel1.TabIndex = 2;
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
            label5.Size = new Size(213, 44);
            label5.TabIndex = 7;
            label5.Text = "Manage Vehicles";
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 69, 111);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 845);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 24);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // RegNumTb
            // 
            RegNumTb.BackColor = SystemColors.ButtonFace;
            RegNumTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            RegNumTb.Location = new Point(166, 187);
            RegNumTb.Multiline = true;
            RegNumTb.Name = "RegNumTb";
            RegNumTb.Size = new Size(331, 34);
            RegNumTb.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(32, 69, 111);
            label8.Location = new Point(12, 187);
            label8.Name = "label8";
            label8.Size = new Size(95, 44);
            label8.TabIndex = 35;
            label8.Text = "RegNo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(32, 69, 111);
            label14.Location = new Point(12, 286);
            label14.Name = "label14";
            label14.Size = new Size(91, 44);
            label14.TabIndex = 32;
            label14.Text = "Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(32, 69, 111);
            label7.Location = new Point(12, 242);
            label7.Name = "label7";
            label7.Size = new Size(165, 44);
            label7.TabIndex = 31;
            label7.Text = "Vehicle Type";
            // 
            // CarDGV
            // 
            CarDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDGV.Location = new Point(530, 211);
            CarDGV.Name = "CarDGV";
            CarDGV.RowHeadersWidth = 51;
            CarDGV.Size = new Size(643, 595);
            CarDGV.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(32, 69, 111);
            label9.Location = new Point(790, 146);
            label9.Name = "label9";
            label9.Size = new Size(162, 44);
            label9.TabIndex = 37;
            label9.Text = "Vehicles List";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 69, 111);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(107, 641);
            button4.Name = "button4";
            button4.Size = new Size(103, 44);
            button4.TabIndex = 48;
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
            button3.Location = new Point(301, 569);
            button3.Name = "button3";
            button3.Size = new Size(117, 43);
            button3.TabIndex = 47;
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
            button2.Location = new Point(175, 567);
            button2.Name = "button2";
            button2.Size = new Size(103, 44);
            button2.TabIndex = 46;
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
            button1.Location = new Point(54, 566);
            button1.Name = "button1";
            button1.Size = new Size(101, 43);
            button1.TabIndex = 45;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(32, 69, 111);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(249, 641);
            button5.Name = "button5";
            button5.Size = new Size(103, 44);
            button5.TabIndex = 49;
            button5.Text = "CLEAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // PriceTb
            // 
            PriceTb.BackColor = SystemColors.ButtonFace;
            PriceTb.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            PriceTb.Location = new Point(166, 349);
            PriceTb.Multiline = true;
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(331, 34);
            PriceTb.TabIndex = 51;
            // 
            // AvailableCb
            // 
            AvailableCb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableCb.ForeColor = Color.FromArgb(32, 69, 111);
            AvailableCb.FormattingEnabled = true;
            AvailableCb.Items.AddRange(new object[] { "Yes", "No", "Cancel" });
            AvailableCb.Location = new Point(166, 412);
            AvailableCb.Name = "AvailableCb";
            AvailableCb.Size = new Size(331, 28);
            AvailableCb.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(32, 69, 111);
            label4.Location = new Point(12, 339);
            label4.Name = "label4";
            label4.Size = new Size(83, 44);
            label4.TabIndex = 50;
            label4.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Agency FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(32, 69, 111);
            label6.Location = new Point(12, 395);
            label6.Name = "label6";
            label6.Size = new Size(123, 44);
            label6.TabIndex = 53;
            label6.Text = "Available";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Van", "Car", "Bike", "Lorry", "Jeep", "Bus", "Three Wheeler" });
            comboBox1.Location = new Point(166, 258);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(331, 28);
            comboBox1.TabIndex = 54;
            // 
            // ModelTb
            // 
            ModelTb.FormattingEnabled = true;
            ModelTb.Items.AddRange(new object[] { "suzuki vaganaar(AC)", "TATA buddy(Non AC)", "Yamaha FZ", "Yamaha FZ-s", "Pulser", "Honda car(AC)", "Toyota(AC)", "TATA bike", "TATA lorry", "" });
            ModelTb.Location = new Point(170, 312);
            ModelTb.Name = "ModelTb";
            ModelTb.Size = new Size(327, 28);
            ModelTb.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(40, 472);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 56;
            label10.Text = "Madel";
            // 
            // Brandcmb
            // 
            Brandcmb.FormattingEnabled = true;
            Brandcmb.Items.AddRange(new object[] { "BMW", "Suzuki" });
            Brandcmb.Location = new Point(170, 474);
            Brandcmb.Name = "Brandcmb";
            Brandcmb.Size = new Size(327, 28);
            Brandcmb.TabIndex = 57;
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 869);
            Controls.Add(Brandcmb);
            Controls.Add(label10);
            Controls.Add(ModelTb);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(AvailableCb);
            Controls.Add(PriceTb);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CarDGV);
            Controls.Add(label9);
            Controls.Add(RegNumTb);
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Car";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car";
            Load += Car_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private TextBox RegNumTb;
        private Label label8;
        private Label label14;
        private Label label7;
        private DataGridView CarDGV;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private TextBox PriceTb;
        private ComboBox AvailableCb;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox ModelTb;
        private Label label10;
        private ComboBox Brandcmb;
    }
}