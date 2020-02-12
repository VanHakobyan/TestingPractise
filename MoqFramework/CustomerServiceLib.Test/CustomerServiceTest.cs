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
            mock.Verify(x => x.Save(It.IsAny<Customer>()), Times.Between(2, 5, Range.Inclusive));
        }

        [TestMethod]
        public void Create_CheckFullName_FromFirstNameAndLastName()
        {
            CustomerDTO customerDto = new CustomerDTO { LastName = "Alexanyan", FirstName = "Samvel" };
            Mock<ICustomerRepository> customRepoMock = new Mock<ICustomerRepository>();
            Mock<INameBuilder> nameBuilderMock = new Mock<INameBuilder>();

            CustomerService customerService = new CustomerService(customRepoMock.Object, nameBuilderMock.Object);

            customerService.Create(customerDto);

            nameBuilderMock.Verify(x => x.From(
                It.Is<string>(v => v.Equals(customerDto.FirstName)),
                It.Is<string>(v => v.Equals(customerDto.LastName))
                ));
        }
    }
}
