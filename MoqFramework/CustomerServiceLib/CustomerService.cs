using System.Collections.Generic;

namespace CustomerServiceLib
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void Create(IEnumerable<CustomerDTO> customers)
        {
            foreach (var customer in customers)
            {
                _repository.Save(new Customer(customer.FirstName,customer.LastName));
            }
        }
    }
}