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
        IWaybillService _waybillService;
        public Form1(IIndividualCustomerServices �ndividualCustomerServices, ICorporateCustomerServices corporateCustomerServices, IWaybillService waybillService)
        {
            _�ndividualCustomerServices = �ndividualCustomerServices;
            _corporateCustomerServices = corporateCustomerServices;
            _waybillService = waybillService;

        }
        public Form1()
        {
            InitializeComponent();

            IIndividualCustomerDal �ndividualCustomerDal = new EfIndividualCustomerDal();
            _�ndividualCustomerServices = new IndividualCustomerManager(�ndividualCustomerDal);

            ICorporateCustomerDal corporateCustomerDal = new EfCorporateCustomerDal();
            _corporateCustomerServices = new CorporateCustomerManager(corporateCustomerDal);

            IWaybillDal waybillDal = new EfWaybillDal();
            _waybillService = new WaybillManager(waybillDal);

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
            //grbKurumsal.Visible = false;
            //grbBireysel.Visible = false;

            IndividualLoadCombo();
            CorporateLoadCombo();


        }

        private void IndividualLoadCombo()
        {
            try
            {
                List<IndividualCustomer> customers = _�ndividualCustomerServices.getall();

                // ComboBox i�in otomatik tamamlama �zelliklerini ayarla
                cmbBireyselSec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbBireyselSec.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // AutoComplete i�in veri kayna�� ayarla
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(customers.Select(c => c.Name).ToArray());

                cmbBireyselSec.AutoCompleteCustomSource = autoCompleteData;

                cmbBireyselSec.DataSource = customers;
                cmbBireyselSec.DisplayMember = "Name";
                cmbBireyselSec.ValueMember = "IndividualCustomerId";
                cmbBireyselSec.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"M��teri eklenirken hata olu�tu: {ex.Message}");
            }
        }

        private void CorporateLoadCombo()
        {
            try
            {
                List<CorporateCustomer> customers = _corporateCustomerServices.getall();

                // ComboBox i�in otomatik tamamlama �zelliklerini ayarla
                cmbKurum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbKurum.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // AutoComplete i�in veri kayna�� ayarla
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(customers.Select(c => c.Name).ToArray());

                cmbKurum.AutoCompleteCustomSource = autoCompleteData;

                cmbKurum.DataSource = customers;
                cmbKurum.DisplayMember = "Name";
                cmbKurum.ValueMember = "CorporateCustomerId";
                cmbKurum.SelectedIndex = -1;
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

        private void t�mM��terilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCorporate allCorporate = new AllCorporate();
            allCorporate.Show();
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
        private void RefreshForm()
        {
            // Formun y�kleme i�lemlerini burada tekrar yap�n
            // �rne�in ComboBox'lar�, ListView'lar�, DataGrid'leri vb. yeniden y�kleyin
            IndividualLoadCombo();
            CorporateLoadCombo();
            // Di�er yenileme i�lemleri
        }

        public void btnBireyselYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string a�iklama = txtBireyselAciklama.Text;
                string fiyat = txtBireyselFiyat.Text;
                string teknisyen = txtBireyselTeknisyen.Text;
                DateTime dateTime = dtimeBireyselTarih.Value;
                //string formattedDate = dateTime.ToString("yyyy-MM-dd");

                // Se�ili m��teriyi al
                IndividualCustomer selectedCustomer = (IndividualCustomer)cmbBireyselSec.SelectedItem;

                Waybill waybill = new Waybill
                {
                    IndividualCustomerId = selectedCustomer.IndividualCustomerId,
                    Date = dateTime,
                    Description = a�iklama,
                    Technician = teknisyen,
                    Amount = decimal.Parse(fiyat)
                };
                // Yeni Waybill'i veritaban�na ekle
                _waybillService.Add(waybill);

                // Ba�ar�l� mesaj� g�ster
                MessageBox.Show("�rsaliye ba�ar�yla eklendi!");

                // Formu yenile
                RefreshForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata olu�tu: {ex.Message}");
            }
        }

        private void btnKurumYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string a�iklama = txtKurumAciklama.Text;
                string fiyat = txtKurumFiyat.Text;
                string teknisyen = txtKurumTeknisyen.Text;
                DateTime dateTime = dtimeKurumtarih.Value;
                //string formattedDate = dateTime.ToString("yyyy-MM-dd");

                // Se�ili m��teriyi al
                CorporateCustomer selectedCustomer = (CorporateCustomer)cmbKurum.SelectedItem;

                Waybill waybill = new Waybill
                {
                    CorporateCustomerId = selectedCustomer.CorporateCustomerId,
                    Date = dateTime,
                    Description = a�iklama,
                    Technician = teknisyen,
                    Amount = decimal.Parse(fiyat)
                };
                // Yeni Waybill'i veritaban�na ekle
                _waybillService.Add(waybill);

                // Ba�ar�l� mesaj� g�ster
                MessageBox.Show("�rsaliye ba�ar�yla eklendi!");

                // Formu yenile
                RefreshForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata olu�tu: {ex.Message}");
            }
        }

    }
}
