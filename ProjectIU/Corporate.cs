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
    public partial class Corporate : Form
    {
        ICorporateCustomerServices _corporateCustomerServices;
        public Corporate(ICorporateCustomerServices corporateCustomerServices)
        {
            _corporateCustomerServices = corporateCustomerServices;
        }

        public Corporate()
        {
            InitializeComponent();
            ICorporateCustomerDal corporateCustomerDal = new EfCorporateCustomerDal();
            _corporateCustomerServices = new CorporateCustomerManager(corporateCustomerDal);

        }

        private void Corporate_Load(object sender, EventArgs e)
        {

        }

        private static void KurumEkle()
        {
            MessageBox.Show("Kurum eklendi");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string address = txtAddress.Text;
                string phone = txtPhoneNumber.Text;

                if (Int64.TryParse(phone, out Int64 phoneNumber))
                {
                    CorporateCustomer corporateCustomer = new CorporateCustomer
                    {
                        Address = address,
                        Phone = phoneNumber,
                        CompanyName = name
                    };
                    _corporateCustomerServices.Add(corporateCustomer);
                    KurumEkle();
                }
            }

            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
