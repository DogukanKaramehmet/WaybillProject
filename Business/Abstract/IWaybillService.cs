using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWaybillService
    {
        List<Waybill> getAll();
        List<WaybillDetailDto> GetWaybillDetails();
        List<Waybill> get(int id);
        void Add(Waybill waybill);
        void Delete(Waybill waybill);
        void Update(Waybill waybill);

    }
}
