using System.Collections.Generic;

namespace CustomerServiceLib
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly INameBuilder _nameBuilder;

        public CustomerService(ICustomerRepository repository, INameBuilder nameBuilder = null)
        {
            _repository = repository;
            _nameBuilder = nameBuilder;
        }

        public void Create(IEnumerable<CustomerDTO> customers)
        {
            foreach (var customer in customers)
            {
                _repository.Save(new Customer(customer.FirstName, customer.LastName));
            }
        }

        public void Create(CustomerDTO customerDto)
        {
            string fullName = _nameBuilder.From(customerDto.FirstName, customerDto.LastName);
            _repository.Save(new Customer(fullName));
        }
    }
}