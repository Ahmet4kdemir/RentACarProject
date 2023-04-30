using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Car is added!";
        public static string ProductNameInvalid = "Car name is invalid!";
        public static string MaintenanceTime = "System is in MaintenanceTime";
        public static string ProductsListed = "Car are listed!";
        public static string Deleted = "Deleted!";
        public static string Updated = "Updated! ";
        public static string FailedOperation = "Operation is failed!";
        public static string CarInvalid = "Car is invailid ";
        public static string CarAdded = "Car is Added!";
        public static string CarsListed = "Cars are listed";
        public static string BrandAdded = "Brand is added";
        public static string BrandDeleted = "Brand is deleted";
        public static string BrandUpdated = "Brand is updated";
        public static string ColorAdded = "Color is added";
        public static string CustomerAdded = "Customer is added";
        public static string RentalAdded = "Rental is added";
        public static string UserAdded = "User is added";
        public static string UserDeleted = "User is deleted";
        public static string UserUpdated = "User is updated";
        public static string CarCountOfBrandError = "you can not add ten or above for this brand";
        public static string CarNameSameError="that car name already exist";
        public static string BrandLimitExceded="brand limit is full that is why you can not add new brand";
    }
}
