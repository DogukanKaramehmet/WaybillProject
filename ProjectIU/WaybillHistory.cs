using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
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
    public partial class WaybillHistory : Form
    {
        IWaybillService _waybillService;
        public WaybillHistory(IWaybillService waybillService)
        {
            _waybillService = waybillService;
        }
        public WaybillHistory()
        {
            InitializeComponent();
            IWaybillDal waybillDal = new EfWaybillDal();
            _waybillService = new WaybillManager(waybillDal);
        }

        private void WaybillHistory_Load(object sender, EventArgs e)
        {
            DataLoad();
            dgwWaybillHistory.CellClick += dgwWaybillHistory_CellClick;

            dgwWaybillHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwWaybillHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void DataLoad()
        {
            List<WaybillDetailDto> waybills = _waybillService.GetWaybillDetails();
            var waybillList = waybills.Select(w => new
            {
                Tarih = w.Date,
                Fiyat = w.Amount,
                Teknisyen = w.Technician,
                Açıklama = w.Description,
                Adi = w.Name,
                Soyadi = w.Surname,
                Tel = w.Phone,
                Adress = w.Address

            }).ToList();

            dgwWaybillHistory.DataSource = waybillList;
        }


        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (dgwWaybillHistory.SelectedRows.Count > 0)
            {
                // Seçili satırı al
                DataGridViewRow selectedRow = dgwWaybillHistory.SelectedRows[0];

                // Satırdaki verileri al

                string customerName = selectedRow.Cells["Adi"].Value.ToString();
                string customerSurname = selectedRow.Cells["Soyadi"].Value.ToString();  
                string phoneNumber = selectedRow.Cells["Tel"].Value.ToString();
                DateTime date = DateTime.Parse(selectedRow.Cells["Tarih"].Value.ToString());
                decimal amount = decimal.Parse(selectedRow.Cells["Fiyat"].Value.ToString());
                string technician = selectedRow.Cells["Teknisyen"].Value.ToString();
                string description = selectedRow.Cells["Açıklama"].Value.ToString();
                string address = selectedRow.Cells["Adress"].Value.ToString();



                // Bilgileri ekrana yazdır
                MessageBox.Show(
                $"Müşteri Adı: {customerName} {customerSurname}\n" + 
                $"Telefon: {phoneNumber}\n" +
                $"Tarih: {date.ToShortDateString()}\n" +
                $"Fiyat: {amount}\n" +
                $"Teknisyen: {technician}\n" +
                $"Açıklama: {description}\n" +
                $"Adres: {address}");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void dgwWaybillHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgwWaybillHistory.Rows[e.RowIndex].Selected = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string serchValue = txtSearch.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(serchValue))
            {
                dgwWaybillHistory.DataSource = _waybillService.GetWaybillDetails().Where(c =>
                c.Name.ToLower().Contains(serchValue) ||
                c.Surname.ToLower().Contains(serchValue)).ToList();
            }
            else
            {
                dgwWaybillHistory.DataSource = _waybillService.GetWaybillDetails();
            }
        }
    }
}
