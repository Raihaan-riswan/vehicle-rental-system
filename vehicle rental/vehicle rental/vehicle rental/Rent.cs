using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_rental
{
    public partial class Rent : Form
    {
        DataTable table = new DataTable();
        public Rent()
        {
            InitializeComponent();
            table.Columns.Add("UserId");
            table.Columns.Add("vehNum");
            table.Columns.Add("CustId");
            table.Columns.Add("Name");
            table.Columns.Add("Rental Date");
            table.Columns.Add("Return Date");
            CarDGV.DataSource = table;
            // InitializeComponent();
        }
        //public Rent()
        //{
        //    InitializeComponent();
        //}

        private void RegNumTb_TextChanged(object sender, EventArgs e)
        {

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
            if (userId.Text == "" || vehRum.Text == "" || CustId.Text == "" || Name.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string rentaldate = rDate.SelectedItem.ToString() + "-" + rMonth.SelectedItem.ToString() + "-" + rYear.SelectedItem.ToString();
                string returndate = comboBox1.SelectedItem.ToString() + "-" + comboBox4.SelectedItem.ToString() + "-" + comboBox5.SelectedItem.ToString();

                if (table != null)
                {
                    table.Rows.Add(userId.Text, vehRum.Text, CustId.Text, Name.Text, rentaldate, returndate);
                    CarDGV.DataSource = table;

                    MessageBox.Show("Added successfully");

                }
            }

        }

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void Rent_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CarDGV.CurrentRow != null)
            {
                int index = CarDGV.CurrentRow.Index;
                table.Rows.RemoveAt(index);

                MessageBox.Show("Delete Successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userId.Text == "" || vehRum.Text == "" || CustId.Text == "" || Name.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int index = CarDGV.CurrentRow.Index;
                table.Rows[index]["userId"] = userId.Text;
                table.Rows[index]["VehNum"] = vehRum.Text;
                table.Rows[index]["CustId"] = CustId.Text;
                table.Rows[index]["Name"] = Name.Text;

                MessageBox.Show("Edit successfully");
            }
        }

        private void userId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       
        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
