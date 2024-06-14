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
    public class WaybillManager : IWaybillService
    {
        IWaybillDal _waybill;
        public WaybillManager(IWaybillDal waybillDal)
        {
            _waybill = waybillDal;
        }
        public void Add(Waybill waybill)
        {
            _waybill.Add(waybill);
        }

        public void Delete(Waybill waybill)
        {
            _waybill.Delete(waybill);
        }

        public List<Waybill> get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Waybill> getAll()
        {
            return _waybill.GetAll();
        }

        public void Update(Waybill waybill)
        {
            _waybill.Update(waybill);
        }
    }
}
