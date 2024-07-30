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
                Soyadi = w.IsCorporate ? "-" : w.Surname, // Kurumsal müşteri ise boş bırak
                Tel = w.Phone,
                Adres = w.Address,
                MüşteriTipi = w.IsCorporate ? "Kurumsal" : "Bireysel" // Müşteri tipi belirt
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
                string address = selectedRow.Cells["Adres"].Value.ToString();
                string customerType = selectedRow.Cells["MüşteriTipi"].Value.ToString();

                // Bilgileri ekrana yazdır
                MessageBox.Show(
                    $"Müşteri Tipi: {customerType}\n" +
                    $"Müşteri Adı: {customerName} {(customerType == "Bireysel" ? customerSurname : "")}\n" +
                    $"Telefon: {phoneNumber}\n" +
                    $"Tarih: {date.ToShortDateString()}\n" +
                    $"Fiyat: {amount}\n" +
                    $"Teknisyen: {technician}\n" +
                    $"Açıklama: {description}\n" +
                    $"Adres: {address}"
                );
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
            string searchValue = txtSearch.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchValue))
            {
                var filteredWaybills = _waybillService.GetWaybillDetails().Where(c =>
                    c.Name.ToLower().Contains(searchValue) ||
                    (!c.IsCorporate && c.Surname.ToLower().Contains(searchValue)) // Bireysel müşteriler için soyadı araması
                ).ToList();

                dgwWaybillHistory.DataSource = filteredWaybills.Select(w => new
                {
                    Tarih = w.Date,
                    Fiyat = w.Amount,
                    Teknisyen = w.Technician,
                    Açıklama = w.Description,
                    Adi = w.Name,
                    Soyadi = w.IsCorporate ? "-" : w.Surname,
                    Tel = w.Phone,
                    Adres = w.Address,
                    MüşteriTipi = w.IsCorporate ? "Kurumsal" : "Bireysel"
                }).ToList();
            }
            else
            {
                DataLoad(); // Filtreleme yoksa, tüm verileri yükleyin
            }
        }
    }
}
