namespace vehicle_rental
{
    public partial class spalash : Form
    {
        public spalash()
        {
            InitializeComponent();
        }

        int startpoint = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            myProgress.Value = startpoint;
            Percentage.Text = "" + startpoint + "%";
            myProgress.ForeColor = Color.Blue;
            if (myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();


            }
        }

        private void spalash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void myProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
