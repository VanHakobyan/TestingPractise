using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CustomerServiceLib.Test
{
    [TestClass]
    public class CustomerServiceTest
    {
        private List<CustomerDTO> _customerList;
           
        [TestInitialize]
        public void Initialise()
        {
            _customerList = new List<CustomerDTO>
            {
                new CustomerDTO {FirstName = "Robert", LastName = "Kocharian"},
                new CustomerDTO {FirstName = "Serj", LastName = "Sarkisian"},
                new CustomerDTO {FirstName = "Grayr", LastName = "Tovmasian"}
            };

        }


        [TestMethod]
        public void CreateMethod_Save_WasCalled()
        {
        
            var mock = new Mock<ICustomerRepository>();
            var cService = new CustomerService(mock.Object);

            //act
            cService.Create(_customerList);

            //assert
            mock.Verify(x => x.Save(It.IsAny<Customer>()));
        }


        [TestMethod]
        public void CreateMethod_Save_WasCalled_ThreeTimes()
        {

            var mock = new Mock<ICustomerRepository>();
            var cService = new CustomerService(mock.Object);

            //act
            cService.Create(_customerList);

            //assert
            mock.Verify(x => x.Save(It.IsAny<Customer>()),Times.Between(2,5,Range.Inclusive));
        }
    }
}
