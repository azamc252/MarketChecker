namespace marketPriceChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metalsPrices2.Visible = true;
            homePage1.Visible = false;
            companyCheck1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homePage1.Visible = true;
            metalsPrices2.Visible = false;
            companyCheck1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metalsPrices2.Visible = false;
            homePage1.Visible = false;
            companyCheck1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homePage1.Visible = true;
            metalsPrices2.Visible = false;
            companyCheck1.Visible = false;
        }

        private void homePage1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}