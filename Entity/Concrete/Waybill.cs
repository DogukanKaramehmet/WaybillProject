using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Waybill:IEntity
    {
        public int WaybillId { get; set; }
        public int? IndividualCustomerId { get; set; }
        public int? CorporateCustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Technician { get; set; }
        public Decimal? Amount { get; set; }

    }
}
