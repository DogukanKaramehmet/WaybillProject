using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWaybillDal : EfEntityRepositoryBase<Waybill, WaybillContext>, IWaybillDal
    {
        public List<WaybillDetailDto> GetWaybillDetails()
        {
            using (WaybillContext context = new WaybillContext())
            {
                var result = from v in context.Waybills
                             join ı in context.IndividualCustomers
                             on v.IndividualCustomerId equals ı.IndividualCustomerId
                             
                             select new WaybillDetailDto
                             {
                                 WaybillId = v.WaybillId,
                                 Amount = v.Amount,
                                 Description = v.Description,
                                 Technician = v.Technician,
                                 Date = v.Date,
                                 Name = ı.Name,
                                 Surname = ı.Surname,
                                 Phone = ı.Phone,
                                 Address= ı.Address
                                 
                             };

                return result.ToList();
            }
        }
    }
}
