using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace ProjectIU
{
    public partial class Form1 : Form
    {
        IIndividualCustomerServices _�ndividualCustomerServices;
        ICorporateCustomerServices _corporateCustomerServices;
        public Form1(IIndividualCustomerServices �ndividualCustomerServices, ICorporateCustomerServices corporateCustomerServices)
        {
            _�ndividualCustomerServices = �ndividualCustomerServices;
            _corporateCustomerServices = corporateCustomerServices;

        }
        public Form1()
        {
            InitializeComponent();
            IIndividualCustomerDal �ndividualCustomerDal = new EfIndividualCustomerDal();
            _�ndividualCustomerServices = new IndividualCustomerManager(�ndividualCustomerDal);

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
                List<IndividualCustomer> customers = _�ndividualCustomerServices.getall();

                cmbBireyselSec.DataSource = customers;
                cmbBireyselSec.DisplayMember = "Name";
                cmbBireyselSec.ValueMember = "IndividualCustomerId";
            }
            catch (Exception ex)
            {

                MessageBox.Show($"M��teri eklenirken hata olu�tu: {ex.Message}");
            }
        }

        private void irsaliyeGe�mi�iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaybillHistory waybillHistory = new WaybillHistory();
            waybillHistory.Show();

        }

        private void bireyselM��teriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Individual �ndividualCustomer = new Individual();
            �ndividualCustomer.Show();
        }

        private void kurumsalM��teriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corporate corporateCustomer = new Corporate();
            corporateCustomer.Show();
        }
    }
}
