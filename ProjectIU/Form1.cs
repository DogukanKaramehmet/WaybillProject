namespace ProjectIU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnBireysel_Click(object sender, EventArgs e)
        {
            grbBireysel.Visible = true;
            grbKurumsal.Visible = false;
        }

        private void btnKurumsal_Click(object sender, EventArgs e)
        {
            grbKurumsal.Visible = true;
            grbBireysel.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grbKurumsal.Visible = false;
            grbBireysel.Visible = false;
        }

        private void irsaliyeGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaybillHistory waybillHistory = new WaybillHistory();
            waybillHistory.Show();

        }

        private void bireyselMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualCustomer ındividualCustomer = new IndividualCustomer();
            ındividualCustomer.Show();
        }

        private void kurumsalMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.Show();
        }
    }
}
