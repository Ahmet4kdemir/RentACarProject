using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        List<Rental> GetRentalById(int rentalId);

        List<Rental> GetAll();
        void Add(Rental rental);
        void Delete(Rental rental);
        void Update(Rental rental);

    }
}
