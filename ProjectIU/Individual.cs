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
            IIndividualCustomerDal customerRepository = new EfIndividualCustomerDal();
            _ındividualCustomerServices = new IndividualCustomerManager(customerRepository);

        }

        private void IndividualCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {



                string name = txtName.Text;
                string surname = txtSurname.Text;
                string phoneText = txtPhoneNumber.Text;
                string address = txtAddress.Text;


                if (int.TryParse(phoneText, out int phoneNumber))
                {

                    IndividualCustomer customer = new IndividualCustomer
                    {
                        Name = name,
                        Surname = surname,
                        Address = address,
                        Phone = phoneNumber
                    };
                    _ındividualCustomerServices.Add(customer);
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
