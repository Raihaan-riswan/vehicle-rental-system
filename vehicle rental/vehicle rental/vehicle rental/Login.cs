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
namespace vehicle_rental
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\carRentaldb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void label6_Click(object sender, EventArgs e)
        {
            IDtb.Clear();
            pwdTb.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select count (*) from UserTbl where Uname='" + IDtb.Text + "' and Upass='" + pwdTb.Text + "'";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            Con.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) 
        {
            if (checkBox1.Checked == true)
            {
                pwdTb.UseSystemPasswordChar = true;

            }
            else {
                pwdTb.UseSystemPasswordChar = false;

            }
        }
    }
}
