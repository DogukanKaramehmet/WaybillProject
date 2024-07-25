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
        IWaybillService _waybillService;
        public Form1(IIndividualCustomerServices ýndividualCustomerServices, ICorporateCustomerServices corporateCustomerServices, IWaybillService waybillService)
        {
            _ýndividualCustomerServices = ýndividualCustomerServices;
            _corporateCustomerServices = corporateCustomerServices;
            _waybillService = waybillService;

        }
        public Form1()
        {
            InitializeComponent();

            IIndividualCustomerDal ýndividualCustomerDal = new EfIndividualCustomerDal();
            _ýndividualCustomerServices = new IndividualCustomerManager(ýndividualCustomerDal);

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
                List<IndividualCustomer> customers = _ýndividualCustomerServices.getall();

                // ComboBox için otomatik tamamlama özelliklerini ayarla
                cmbBireyselSec.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbBireyselSec.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // AutoComplete için veri kaynaðý ayarla
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

                MessageBox.Show($"Müþteri eklenirken hata oluþtu: {ex.Message}");
            }
        }

        private void CorporateLoadCombo()
        {
            try
            {
                List<CorporateCustomer> customers = _corporateCustomerServices.getall();

                // ComboBox için otomatik tamamlama özelliklerini ayarla
                cmbKurum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbKurum.AutoCompleteSource = AutoCompleteSource.CustomSource;

                // AutoComplete için veri kaynaðý ayarla
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

        private void tümMüþterilerToolStripMenuItem_Click(object sender, EventArgs e)
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
            // Formun yükleme iþlemlerini burada tekrar yapýn
            // Örneðin ComboBox'larý, ListView'larý, DataGrid'leri vb. yeniden yükleyin
            IndividualLoadCombo();
            CorporateLoadCombo();
            // Diðer yenileme iþlemleri
        }

        public void btnBireyselYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string açiklama = txtBireyselAciklama.Text;
                string fiyat = txtBireyselFiyat.Text;
                string teknisyen = txtBireyselTeknisyen.Text;
                DateTime dateTime = dtimeBireyselTarih.Value;
                //string formattedDate = dateTime.ToString("yyyy-MM-dd");

                // Seçili müþteriyi al
                IndividualCustomer selectedCustomer = (IndividualCustomer)cmbBireyselSec.SelectedItem;

                Waybill waybill = new Waybill
                {
                    IndividualCustomerId = selectedCustomer.IndividualCustomerId,
                    Date = dateTime,
                    Description = açiklama,
                    Technician = teknisyen,
                    Amount = decimal.Parse(fiyat)
                };
                // Yeni Waybill'i veritabanýna ekle
                _waybillService.Add(waybill);

                // Baþarýlý mesajý göster
                MessageBox.Show("Ýrsaliye baþarýyla eklendi!");

                // Formu yenile
                RefreshForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message}");
            }
        }

        private void btnKurumYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string açiklama = txtKurumAciklama.Text;
                string fiyat = txtKurumFiyat.Text;
                string teknisyen = txtKurumTeknisyen.Text;
                DateTime dateTime = dtimeKurumtarih.Value;
                //string formattedDate = dateTime.ToString("yyyy-MM-dd");

                // Seçili müþteriyi al
                CorporateCustomer selectedCustomer = (CorporateCustomer)cmbKurum.SelectedItem;

                Waybill waybill = new Waybill
                {
                    CorporateCustomerId = selectedCustomer.CorporateCustomerId,
                    Date = dateTime,
                    Description = açiklama,
                    Technician = teknisyen,
                    Amount = decimal.Parse(fiyat)
                };
                // Yeni Waybill'i veritabanýna ekle
                _waybillService.Add(waybill);

                // Baþarýlý mesajý göster
                MessageBox.Show("Ýrsaliye baþarýyla eklendi!");

                // Formu yenile
                RefreshForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message}");
            }
        }

    }
}
