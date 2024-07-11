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
    public class IndividualCustomerManager : IIndividualCustomerServices
    {
        IIndividualCustomerDal _ındividualCustomerDal;
        public IndividualCustomerManager(IIndividualCustomerDal ındividualCustomerDal)
        {
            _ındividualCustomerDal = ındividualCustomerDal;
        }

        public void Add(IndividualCustomer ındividualCustomer)
        {
            _ındividualCustomerDal.Add(ındividualCustomer);
        }

        public void Delete(IndividualCustomer ındividualCustomer)
        {
            _ındividualCustomerDal.Delete(ındividualCustomer);
        }

        public List<IndividualCustomer> get(int id)
        {
            throw new NotImplementedException();
        }

        public List<IndividualCustomer> getall()
        {
           return _ındividualCustomerDal.GetAll();
        }

        public void Update(IndividualCustomer ındividualCustomer)
        {
            _ındividualCustomerDal.Update(ındividualCustomer);
        }
    }
}
