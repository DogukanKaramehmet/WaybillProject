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
    public partial class Individual : Form
    {
        IIndividualCustomerServices _ındividualCustomerServices;
        public Individual(IIndividualCustomerServices ındividualCustomerServices)
        {
            _ındividualCustomerServices = ındividualCustomerServices;
        }
        public Individual()
        {
            InitializeComponent();
            IIndividualCustomerDal ındividualCustomerDal = new EfIndividualCustomerDal();
            _ındividualCustomerServices = new IndividualCustomerManager(ındividualCustomerDal);

        }

        private void IndividualCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Added();
        }

        private void Added()
        {
            try
            {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string phoneText = txtPhoneNumber.Text;
                string address = txtAddress.Text;


                if (Int64.TryParse(phoneText, out Int64 phoneNumber))
                {

                    IndividualCustomer customer = new IndividualCustomer
                    {
                        Name = name,
                        Surname = surname,
                        Address = address,
                        Phone = phoneNumber
                    };
                    _ındividualCustomerServices.Add(customer);
                    KişiEklendi();
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private static void KişiEklendi()
        {
            MessageBox.Show("Kişi Eklendi");
        }
    }
}
