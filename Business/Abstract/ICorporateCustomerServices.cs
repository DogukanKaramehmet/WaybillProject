using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICorporateCustomerServices
    {
        List<CorporateCustomer> getall();
        List<CorporateCustomer> get(int id);
        void Add(CorporateCustomer corporateCustomer);
        void Delete(CorporateCustomer corporateCustomer);
        void Update(CorporateCustomer corporateCustomer);
    }
}
