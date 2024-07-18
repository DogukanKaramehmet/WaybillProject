using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace ProjectIU
{
    public partial class Form1 : Form
    {
        IIndividualCustomerServices _ýndividualCustomerServices;
        ICorporateCustomerServices _corporateCustomerServices;
        public Form1(IIndividualCustomerServices ýndividualCustomerServices, ICorporateCustomerServices corporateCustomerServices)
        {
            _ýndividualCustomerServices = ýndividualCustomerServices;
            _corporateCustomerServices = corporateCustomerServices;

        }
        public Form1()
        {
            InitializeComponent();
            IIndividualCustomerDal ýndividualCustomerDal = new EfIndividualCustomerDal();
            _ýndividualCustomerServices = new IndividualCustomerManager(ýndividualCustomerDal);

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
                List<IndividualCustomer> customers = _ýndividualCustomerServices.getall();

                cmbBireyselSec.DataSource = customers;
                cmbBireyselSec.DisplayMember = "Name";
                cmbBireyselSec.ValueMember = "IndividualCustomerId";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Müþteri eklenirken hata oluþtu: {ex.Message}");
            }
        }

        private void irsaliyeGeçmiþiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaybillHistory waybillHistory = new WaybillHistory();
            waybillHistory.Show();

        }

        private void bireyselMüþteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Individual ýndividualCustomer = new Individual();
            ýndividualCustomer.Show();
        }

        private void kurumsalMüþteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corporate corporateCustomer = new Corporate();
            corporateCustomer.Show();
        }
    }
}
