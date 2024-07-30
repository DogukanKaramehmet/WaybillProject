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
                var individualResults = from v in context.Waybills
                                        join i in context.IndividualCustomers
                                        on v.IndividualCustomerId equals i.IndividualCustomerId
                                        where v.IndividualCustomerId != null // Bireysel müşteri verisi varsa
                                        select new WaybillDetailDto
                                        {
                                            WaybillId = v.WaybillId,
                                            Amount = v.Amount,
                                            Description = v.Description,
                                            Technician = v.Technician,
                                            Date = v.Date,
                                            Name = i.Name,
                                            Surname = i.Surname,
                                            Phone = i.Phone,
                                            Address = i.Address,
                                            IsCorporate = false // Bireysel müşteri
                                        };

                var corporateResults = from v in context.Waybills
                                       join c in context.CorporateCustomers
                                       on v.CorporateCustomerId equals c.CorporateCustomerId
                                       where v.CorporateCustomerId != null // Kurumsal müşteri verisi varsa
                                       select new WaybillDetailDto
                                       {
                                           WaybillId = v.WaybillId,
                                           Amount = v.Amount,
                                           Description = v.Description,
                                           Technician = v.Technician,
                                           Date = v.Date,
                                           Name = c.Name, 
                                           Surname = null, // Kurumsal müşteri olduğu için boş bırakabiliriz
                                           Phone = c.Phone,
                                           Address = c.Address,
                                           IsCorporate = true // Kurumsal müşteri
                                       };

                // İki sonucu birleştir
                var result = individualResults.Union(corporateResults).ToList();

                return result;
            }
        }
    }
}
