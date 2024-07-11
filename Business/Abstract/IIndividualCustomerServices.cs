using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIndividualCustomerServices
    {
        List<IndividualCustomer> getall();
        List<IndividualCustomer> get(int id);
        void Add(IndividualCustomer ındividualCustomer);
        void Delete(IndividualCustomer ındividualCustomer);
        void Update(IndividualCustomer ındividualCustomer);

    }
}
