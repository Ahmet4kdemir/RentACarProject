using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var item in carManager.GetAll())
{
    Console.WriteLine( item.CarId );
}