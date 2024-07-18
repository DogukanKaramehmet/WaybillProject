using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace ProjectIU
{
    public partial class Form1 : Form
    {
        IIndividualCustomerServices _ındividualCustomerServices;
        ICorporateCustomerServices _corporateCustomerServices;
        public Form1(IIndividualCustomerServices ındividualCustomerServices, ICorporateCustomerServices corporateCustomerServices)
        {
            _ındividualCustomerServices = ındividualCustomerServices;
            _corporateCustomerServices = corporateCustomerServices;

        }
        public Form1()
        {
            InitializeComponent();
            IIndividualCustomerDal ındividualCustomerDal = new EfIndividualCustomerDal();
            _ındividualCustomerServices = new IndividualCustomerManager(ındividualCustomerDal);

        }

        private void btnBireysel_Click(object sender, EventArgs e)
        {
            //grbBireysel.Visible = true;
            //grbKurumsal.Visible = false;
        }

        private void btnKurumsal_Click(object sender, EventArgs e)
        {
            //grbKurumsal.Visible = true;
            //grbBireysel.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // grbKurumsal.Visible = false;
            // grbBireysel.Visible = false;

            individualLoadCombo();

        }

        private void individualLoadCombo()
        {
            try
            {
                List<IndividualCustomer> customers = _ındividualCustomerServices.getall();

                cmbBireyselSec.DataSource = customers;
                cmbBireyselSec.DisplayMember = "Name";
                cmbBireyselSec.ValueMember = "IndividualCustomerId";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Müşteri eklenirken hata oluştu: {ex.Message}");
            }
        }

        private void irsaliyeGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaybillHistory waybillHistory = new WaybillHistory();
            waybillHistory.Show();

        }

        private void bireyselMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Individual ındividualCustomer = new Individual();
            ındividualCustomer.Show();
        }

        private void kurumsalMüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corporate corporateCustomer = new Corporate();
            corporateCustomer.Show();
        }
    }
}
