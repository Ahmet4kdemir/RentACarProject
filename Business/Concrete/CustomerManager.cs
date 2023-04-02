using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetCustomerById(int customerId)
        {
            return _customerDal.GetAll(u => u.CustomerId == customerId);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
           
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
           
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
            
        }
    }
}
