using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace vehicle_rental
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\carRentaldb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM UserTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
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
                    string query = "INSERT INTO UserTbl (Uid, Uname, Upass) VALUES (@Uid, @Uname,@Upass)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Uid", Uid.Text);
                    cmd.Parameters.AddWithValue("@Uname", Uname.Text);
                    cmd.Parameters.AddWithValue("@Upass", Upass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "")
            {
                MessageBox.Show("Misssing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM UserTbl WHERE Uid=" + Uid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void UserDGV_CellContent(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.RowIndex>= 0)
            //{
            //  DataGridViewRow row = UserDGV.Rows[e.RowIndex];
            //    Uid.Text = UserDGV.CurrentRow.Cells[1].Value.ToString();
            //    Uname.Text = UserDGV.CurrentRow.Cells[2].Value.ToString();
            //    Upass.Text = UserDGV.CurrentRow.Cells[3].Value.ToString();
            //}
        }


        //private void UserDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = UserDGV.Rows[e.RowIndex];
        //        Uid.Text = UserDGV.CurrentRow.Cells[1].Value.ToString();
        //        Uname.Text = UserDGV.CurrentRow.Cells[2].Value.ToString();
        //        Upass.Text = UserDGV.CurrentRow.Cells[3].Value.ToString();
        //    }
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
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
                    string query = "UPDATE UserTbl SET Uname=@Uname, Upass=@Upass WHERE Uid=@Uid";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@Uid", Uid.Text);
                    cmd.Parameters.AddWithValue("@Uname", Uname.Text);
                    cmd.Parameters.AddWithValue("@Upass", Upass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void UserDGV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UserDGV.Rows[e.RowIndex];
                Uid.Text = UserDGV.CurrentRow.Cells[0].Value.ToString();
                Uname.Text = UserDGV.CurrentRow.Cells[1].Value.ToString();
                Upass.Text = UserDGV.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Uid.Clear();
            Upass.Clear();
            Uname.Clear();
        }

        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

