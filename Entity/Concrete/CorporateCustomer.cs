using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CorporateCustomer:IEntity
    {
        public int CorporateCustomerId { get; set; }
        public string CompanyName { get; set; }
        public Int64 Phone { get; set; }
        public string Address { get; set; }
    }
}
