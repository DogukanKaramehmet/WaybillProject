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
            List<Waybill> waybills = _waybillService.getAll();
            var waybillList = waybills.Select(w => new
            {
                Tarih = w.Date,
                Fiyat = w.Amount,
                Teknisyen = w.Technician,
                Açıklama = w.Description
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

                DateTime date = DateTime.Parse(selectedRow.Cells["Tarih"].Value.ToString());
                decimal? amount = selectedRow.Cells["Fiyat"].Value as decimal?;
                string technician = selectedRow.Cells["Teknisyen"].Value.ToString();
                string description = selectedRow.Cells["Açıklama"].Value.ToString();


                // Bilgileri ekrana yazdır
                MessageBox.Show(
                $"Tarih: {date.ToShortDateString()}\n" +
                $"Fiyat: {amount}\n" +
                $"Teknisyen: {technician}\n" +
                $"Açıklama: {description}");
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
    }
}
