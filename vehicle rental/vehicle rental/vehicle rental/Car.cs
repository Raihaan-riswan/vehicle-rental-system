using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vehicle_rental
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\carRentaldb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void Car_Load(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM CarTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            RegNumTb.Clear();
            // comboBox1.Clear();
            //ModelTb.Clear();
            PriceTb.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || comboBox1.Text == "" || ModelTb.Text == "" || PriceTb.Text == "" || Brandcmb.Text=="")
            {
                MessageBox.Show("Missing  information");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }
                    string query = "INSERT INTO CarTbl (RegNum, vehicle, Model, Available, Price, Brand) VALUES (@RegNum, @vehicle, @Model, @Available, @Price)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@RegNum", RegNumTb.Text);

                    cmd.Parameters.AddWithValue("@vehicle", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Model", ModelTb.Text);
                    cmd.Parameters.AddWithValue("@Available", AvailableCb.Text);
                    cmd.Parameters.AddWithValue("@Price", PriceTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle Successfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Car_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || comboBox1.Text == "" || ModelTb.Text == "" || PriceTb.Text == "" || AvailableCb.Text == "")
            {
                MessageBox.Show("Missing Information");
                return;
            }
            if (!decimal.TryParse(PriceTb.Text, out _))
            {
                MessageBox.Show(" Please enter a valid number for price.");
                return;
            }
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\carRentaldb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionstring))
                {
                    Con.Open();
                    string updateQuery = "UPDATE CarTbl SET Model=@Model, vehicle=@vehicle, Available=@Available, Price=@Price, Model as @Brand WHERE RegNum=@RegNum";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@RegNum", RegNumTb.Text.Trim());

                        cmd.Parameters.AddWithValue("@vehicle", comboBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Model", ModelTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Available", AvailableCb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", PriceTb.Text.Trim());
                        cmd.Parameters.AddWithValue("@Brand", Brandcmb.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Vehicle Successfully Updated");
                            populate();
                        }
                        else
                        {
                            MessageBox.Show("vehicle Not Found");
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void ModelTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

