using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
       //CarManager carManager = new CarManager(new EfCarDal());
       //ICarService carService = new CarManager(new EfCarDal());
        IColorService colorService = new ColorManager(new EfColorDal());
        IBrandService brandService = new BrandManager(new EfBrandDal());
        ICustomerService customerService = new CustomerManager(new EfCustomerDal());
        IUserService userService = new UserManager(new EfUserDal());
        IRentalService rentalManager = new RentalManager(new EfRentalDal());


        //AddColor(colorService);
        // GetCarDetailss(carService);
        //CarTest();
        //DeleteColor(colorService);
        //AddColor(colorService);
        //DeleteColor(colorService);
        //UpdateColor(colorService);
        //GetColorById(colorService);
        //GetAllColors(colorService);
        //GetCarDetailss(carService);


        static void GetCarDetailss(ICarService carService)
        {
            var result = carService.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
        }
        static void CarTest(CarManager carManager)
        {

            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.CarId);
            }
        }
         static void AddColor(IColorService colorService)
        {
            colorService.Add(new Color() { ColorName = "test99" });
        }
         static void DeleteColor(IColorService colorService)
        {
            colorService.Delete(new Color() { ColorId = 4 });
        }

         static void GetCarById(ICarService carService)
        {
            var result = carService.GetCarsByBrandId(5);
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
        }

         static void CarGetAll(ICarService carService)
        {
            var result = carService.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + " " + car.Description);
            }
        }


         static void AddCar(ICarService carService)
        {
            carService.Add(new Car()
            { CarName = "test5", BrandId = 1, ColorId = 1, DailyPrice = 11, ModelYear = 111, Description = "test5" });
        }

         static void DeleteCar(ICarService carService)
        {
            carService.Delete(new Car() { CarId = 1006 });
        }

         static void UpdateCar(ICarService carService)
        {
            carService.Update(new Car()
            {
                CarId = 1,
                Description = "updated",
                DailyPrice = 2247,
                CarName = "test",
                ColorId = 1,
                ModelYear = 1999,
                BrandId = 1
            });
        }
    }
}