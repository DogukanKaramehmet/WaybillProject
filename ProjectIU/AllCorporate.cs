using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
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
        public AllCorporate(IIndividualCustomerServices ındividualCustomerServices)
        {
            _ındividualCustomerServices = ındividualCustomerServices;
        }
        public AllCorporate()
        {
            InitializeComponent();
            dgwCorporate.CellClick += dgwCorporate_CellClick;

            IIndividualCustomerDal ındividualCustomerDal = new EfIndividualCustomerDal();
            _ındividualCustomerServices = new IndividualCustomerManager(ındividualCustomerDal);
        }

        private void AllCorporate_Load(object sender, EventArgs e)
        {
            DataLoad();

            dgwCorporate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwCorporate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // TextBox'ın TextChanged olayını bağlayın
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void DataLoad()
        {
            dgwCorporate.DataSource = _ındividualCustomerServices.getall();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string serchValue = txtSearch.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(serchValue))
            {
                dgwCorporate.DataSource = _ındividualCustomerServices.getall().Where(c =>
                c.Name.ToLower().Contains(serchValue) ||
                c.Surname.ToLower().Contains(serchValue)).ToList();
            }
            else
            {
                dgwCorporate.DataSource = _ındividualCustomerServices.getall();
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

                    // Seçili satırdan ID'yi al
                    int selectedCustomerId = Convert.ToInt32(selectedRow.Cells["IndividualCustomerId"].Value);

                    // Müşteriyi ID'ye göre bul
                    IndividualCustomer customerToDelete = _ındividualCustomerServices.getall()
                        .SingleOrDefault(c => c.IndividualCustomerId == selectedCustomerId);

                    if (customerToDelete != null)
                    {
                        // Müşteriyi sil
                        _ındividualCustomerServices.Delete(customerToDelete);

                        // DataGridView'i güncelle
                        DataLoad();

                        MessageBox.Show("Müşteri başarıyla silindi.");
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
    }
}
