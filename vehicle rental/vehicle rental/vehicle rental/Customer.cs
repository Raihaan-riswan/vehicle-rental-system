using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_rental
{
    public partial class Customer : Form
    {
        DataTable table = new DataTable();
        public Customer()
        {
            InitializeComponent();
            table.Columns.Add("CusId");
            table.Columns.Add("Name");
            table.Columns.Add("Address");
            table.Columns.Add("phone");
            CusDGV.DataSource = table;
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


        private void button1_Click(object sender, EventArgs e)
        {

            table.Rows.Add(Id.Text, Name.Text, Address.Text, Phone.Text);
            CusDGV.DataSource = table;

            //    if (Id.Text == "" || Name.Text == "" || Address.Text == "" || Phone.Text == "")
            //    {
            //        MessageBox.Show("Missing  information");
            //    }
            //    else
            //    {
            //        try
            //        {
            //            if (Con.State == ConnectionState.Closed)
            //            {
            //                Con.Open();
            //            }
            //            string query = "INSERT INTO CustomerTbl (Id, Name, Address, Phone) VALUES (@Id, @Name, @Address, @Phone)";
            //            SqlCommand cmd = new SqlCommand(query, Con);
            //            cmd.Parameters.AddWithValue("@Id", Id.Text);

            //            cmd.Parameters.AddWithValue("@Name", Name.Text);
            //            cmd.Parameters.AddWithValue("@Address", Address.Text);
            //            cmd.Parameters.AddWithValue("Phone", Phone.Text);

            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("Customer Successfully Added");
            //            Con.Close();
            //            populate();

            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
        }
        private void Customer_Load_1(object sender, EventArgs e)
        {
            // populate();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CusDGV.CurrentRow != null)
            {
                int index = CusDGV.CurrentRow.Index;
                table.Rows[index]["CusId"] = Id.Text;
                table.Rows[index]["Name"] = Name.Text;
                table.Rows[index]["Address"] = Address.Text;
                table.Rows[index]["Phone"] = Phone.Text;

                MessageBox.Show("Edit successfully");
            }
        }

        private void CusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CusDGV.CurrentRow != null)
            {
                int index = CusDGV.CurrentRow.Index;
                table.Rows.RemoveAt(index);

                MessageBox.Show("Delete Successfully");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Id.Clear();

        }
    }
}

