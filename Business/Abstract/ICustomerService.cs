using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
       List<Customer> GetCustomerById(int customerId);

        List<Customer> GetAll();
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
