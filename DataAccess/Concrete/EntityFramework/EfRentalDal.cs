using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in context.Car
                             join b in context.Brand
                             on ca.BrandId equals b.BrandId
                             join re in context.Rental
                             on ca.CarId equals re.CarId
                             join co in context.Color
                             on ca.ColorId equals co.ColorId
                             from u in context.User
                             join cu in context.Customer
                             on u.UserId equals cu.UserId
                             from ren in context.Rental
                             join cus in context.Customer
                             on ren.CustomerId equals cus.CustomerId
                             select new RentalDetailDto
                             {
                                 CarId = ca.CarId,
                                 BrandId = b.BrandId,
                                 CustomerId = cus.CustomerId,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 ModelName = ca.ModelName,
                                 RentalId = re.RentalId,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 CustomerName = u.FirstName,
                                 CustomerLastname = u.LastName

                             };
                return result.ToList();
            }
        }
    }
}
