using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class WaybillDetailDto:IEntity
    {
        public int WaybillId { get; set; }
        public string Description { get; set; }
        public string Technician { get; set; }
        public Decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Int64 Phone { get; set; }
        public string Address { get; set; }
        public bool IsCorporate { get; set; } // Müşteri tipi belirlemek için ekleyelim
    }
}
