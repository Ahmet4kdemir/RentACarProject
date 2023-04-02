using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;


        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public List<Rental> GetRentalById(int rentalId)
        {
            return _rentalDal.GetAll(r => r.Id == rentalId);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public void Add(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (result != null)
            {
                Console.WriteLine( "error");
            }
            _rentalDal.Add(rental);
            Console.WriteLine("success");
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            
        }

        public void Update(Rental rental)
        {
            _rentalDal.Update(rental);
            
        }
        public List<Rental> RentedCars()
        {
           return _rentalDal.GetAll(r => r.ReturnDate == null);
        }
    }
}
