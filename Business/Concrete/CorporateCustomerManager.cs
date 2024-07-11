using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CorporateCustomerManager : ICorporateCustomerServices
    {
        ICorporateCustomerDal _corporateCustomerDal;
        public CorporateCustomerManager (ICorporateCustomerDal corporateCustomerDal)
        {
            _corporateCustomerDal = corporateCustomerDal;
        }
        public void Add(CorporateCustomer corporateCustomer)
        {
            _corporateCustomerDal.Add(corporateCustomer);
        }

        public void Delete(CorporateCustomer corporateCustomer)
        {
            _corporateCustomerDal.Delete(corporateCustomer);
        }

        public List<CorporateCustomer> get(int id)
        {
            throw new NotImplementedException();
        }

        public List<CorporateCustomer> getall()
        {
            return _corporateCustomerDal.GetAll();
        }

        public void Update(CorporateCustomer corporateCustomer)
        {
            _corporateCustomerDal.Update(corporateCustomer);
        }
    }
}
