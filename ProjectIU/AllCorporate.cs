using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIU
{
    public partial class AllCorporate : Form
    {
        IIndividualCustomerServices _ındividualCustomerServices;
        ICorporateCustomerServices _corporateCustomerServices;

        private bool isIndividualDataLoaded = true;
        private bool isDeleting = false; // Silme işlemi kilidi

        public AllCorporate(IIndividualCustomerServices ındividualCustomerServices, ICorporateCustomerServices corporateCustomerServices)
        {
            _ındividualCustomerServices = ındividualCustomerServices;
            _corporateCustomerServices = corporateCustomerServices;
        }

        public AllCorporate()
        {
            InitializeComponent();

            // Olayları yalnızca bir kez ekleyin
            //dgwCorporate.CellContentClick += dgwCorporate_CellClick;

            IIndividualCustomerDal ındividualCustomerDal = new EfIndividualCustomerDal();
            _ındividualCustomerServices = new IndividualCustomerManager(ındividualCustomerDal);

            ICorporateCustomerDal corporateCustomerDal = new EfCorporateCustomerDal();
            _corporateCustomerServices = new CorporateCustomerManager(corporateCustomerDal);
        }

        private void AllCorporate_Load(object sender, EventArgs e)
        {
            AddDeleteButtonColumn();

            dgwCorporate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwCorporate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // TextBox'ın TextChanged olayını bağlayın
            txtSearch.TextChanged += txtSearch_TextChanged;

            IndividualDataLoad();
        }

        private void IndividualDataLoad()
        {
            isIndividualDataLoaded = true;
            dgwCorporate.DataSource = _ındividualCustomerServices.getall();
        }
        private void CorporateDataLoad()
        {
            isIndividualDataLoaded = false;
            dgwCorporate.DataSource = _corporateCustomerServices.getall();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchValue))
            {
                if (isIndividualDataLoaded)
                {
                    dgwCorporate.DataSource = _ındividualCustomerServices.getall().Where(c =>
                        c.Name.ToLower().Contains(searchValue) ||
                        c.Surname.ToLower().Contains(searchValue)).ToList();
                }
                else
                {
                    dgwCorporate.DataSource = _corporateCustomerServices.getall().Where(c =>
                        c.Name.ToLower().Contains(searchValue)).ToList();
                }
            }
            else
            {
                if (isIndividualDataLoaded)
                {
                    dgwCorporate.DataSource = _ındividualCustomerServices.getall();
                }
                else
                {
                    dgwCorporate.DataSource = _corporateCustomerServices.getall();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwCorporate.SelectedRows.Count > 0)
            {
                try
                {
                    // Seçili satırı al
                    DataGridViewRow selectedRow = dgwCorporate.SelectedRows[0];

                    if (isIndividualDataLoaded)
                    {
                        // Bireysel müşteri silme işlemi
                        int selectedCustomerId = Convert.ToInt32(selectedRow.Cells["IndividualCustomerId"].Value);
                        IndividualCustomer customerToDelete = _ındividualCustomerServices.getall()
                            .SingleOrDefault(c => c.IndividualCustomerId == selectedCustomerId);

                        if (customerToDelete != null)
                        {
                            _ındividualCustomerServices.Delete(customerToDelete);
                            IndividualDataLoad(); // Veri kaynağını güncelle
                            MessageBox.Show("Bireysel müşteri başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bulunamadı.");
                        }
                    }
                    else
                    {
                        // Kurumsal müşteri silme işlemi
                        int selectedCustomerId = Convert.ToInt32(selectedRow.Cells["CorporateCustomerId"].Value);
                        CorporateCustomer customerToDelete = _corporateCustomerServices.getall()
                            .SingleOrDefault(c => c.CorporateCustomerId == selectedCustomerId);

                        if (customerToDelete != null)
                        {
                            _corporateCustomerServices.Delete(customerToDelete);
                            CorporateDataLoad(); // Veri kaynağını güncelle
                            MessageBox.Show("Kurumsal müşteri başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Müşteri bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
            }
        }
        private void dgwCorporate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgwCorporate.Rows[e.RowIndex].Selected = true;
            }
        }
        private void DeleteIndividualCustomer(int rowIndex)
        {
            try
            {
                // Seçili satırdan ID'yi al
                int selectedCustomerId = Convert.ToInt32(dgwCorporate.Rows[rowIndex].Cells["IndividualCustomerId"].Value);

                // Müşteriyi ID'ye göre bul
                IndividualCustomer customerToDelete = _ındividualCustomerServices.getall()
                    .SingleOrDefault(c => c.IndividualCustomerId == selectedCustomerId);

                if (customerToDelete != null)
                {
                    // Müşteriyi sil
                    _ındividualCustomerServices.Delete(customerToDelete);

                    IndividualDataLoad(); // Yüklemeyi burada yaparak satırın güncellenmesini sağla

                    MessageBox.Show("Bireysel müşteri başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void DeleteCorporateCustomer(int rowIndex)
        {
            try
            {
                // Seçili satırdan ID'yi al
                int selectedCustomerId = Convert.ToInt32(dgwCorporate.Rows[rowIndex].Cells["CorporateCustomerId"].Value);

                // Müşteriyi ID'ye göre bul
                CorporateCustomer customerToDelete = _corporateCustomerServices.getall()
                    .SingleOrDefault(c => c.CorporateCustomerId == selectedCustomerId);

                if (customerToDelete != null)
                {
                    // Müşteriyi sil
                    _corporateCustomerServices.Delete(customerToDelete);

                    CorporateDataLoad();

                    MessageBox.Show("Kurumsal müşteri başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void btnIndividual_Click(object sender, EventArgs e)
        {
            IndividualDataLoad();
        }

        private void btnCorporate_Click(object sender, EventArgs e)
        {
            CorporateDataLoad();
        }
        private void AddDeleteButtonColumn()
        {

        }
    }
}
