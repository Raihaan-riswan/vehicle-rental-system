using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vehicle_rental
{
    public partial class Return : Form
    {
        DataTable table = new DataTable();
        public Return()
        {
            InitializeComponent();
            table.Columns.Add("UserId");
            table.Columns.Add("vehNum");
            table.Columns.Add("CustId");
            table.Columns.Add("Name");
            //table.Columns.Add("Rental Date");
            table.Columns.Add("Return Date");
            table.Columns.Add("Delay");
            table.Columns.Add("Fine");
            table.Columns.Add("Return time");
            ReturnDGV.DataSource = table;
            // InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserId.Text == "" || vehRum.Text == "" || CustId.Text == "" || Name.Text == "" || Delay.Text == "" || Fine.Text == ""  || Time.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string rentaldate = rDate.SelectedItem.ToString() + "-" + rMonth.SelectedItem.ToString() + "-" + rYear.SelectedItem.ToString();


                if (table != null)
                {
                    table.Rows.Add(UserId.Text, vehRum.Text, CustId.Text, Name.Text,Time.Text,rentaldate, Delay.Text, Fine.Text);
                    ReturnDGV.DataSource = table;

                    MessageBox.Show("Added successfully");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserId.Text == "" || vehRum.Text == "" || CustId.Text == "" || Name.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int index = ReturnDGV.CurrentRow.Index;
                table.Rows[index]["userId"] = UserId.Text;
                table.Rows[index]["VehNum"] = vehRum.Text;
                table.Rows[index]["CustId"] = CustId.Text;
                table.Rows[index]["Name"] = Name.Text;
                table.Rows[index]["Delay"] = Delay.Text;
                table.Rows[index]["Fine"] = Fine.Text;
                table.Rows[index]["Name"] = Name.Text;

                MessageBox.Show("Edit successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ReturnDGV.CurrentRow != null)
            {
                int index = ReturnDGV.CurrentRow.Index;
                table.Rows.RemoveAt(index);

                MessageBox.Show("Delete Successfully");
            }
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
