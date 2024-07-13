using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class IndividualCustomer:IEntity
    {
        public int IndividualCustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Int64 Phone { get; set; }
        public string Address { get; set; }

    }
}
