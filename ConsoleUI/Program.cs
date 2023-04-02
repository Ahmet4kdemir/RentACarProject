using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;









//CarTest();



static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var item in carManager.GetAll())
    {
        Console.WriteLine(item.CarId);
    }
}