using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BE
{
    public class CustomerTest
    {
        [Fact]
        public void CustomerNumberSetGetTest()
        {
            //Arrange 
            ICustomer customer = new Customer();
            int expectedCustomerNumber = 1;

            //Act 
            customer.CustomerNumber = expectedCustomerNumber;

            //Assert
            Assert.Equal(expectedCustomerNumber, customer.CustomerNumber);
        }

        [Fact]
        public void NameSetGetTest()
        {
            //Arrange 
            ICustomer customer = new Customer();
            string expectedName = "Kent";

            //Act 
            customer.Name = expectedName;

            //Assert
            Assert.Equal(expectedName, customer.Name);
        }

        [Fact]
        public void AddressSetGetTest()
        {
            //Arrange 
            ICustomer customer = new Customer();
            string expectedAddress = "Korkvej";

            //Act 
            customer.Address = expectedAddress;

            //Assert
            Assert.Equal(expectedAddress, customer.Address);
        }

        [Fact]
        public void PhoneNumberSetGetTest()
        {
            //Arrange 
            ICustomer customer = new Customer();
            string expectedPhoneNumber = "23109281";

            //Act 
            customer.PhoneNumber = expectedPhoneNumber;

            //Assert
            Assert.Equal(expectedPhoneNumber, customer.PhoneNumber);
        }

        [Fact]
        public void EmailSetGetTest()
        {
            //Arrange 
            ICustomer customer = new Customer();
            string expectedEmail = "Kork@gmail.com";

            //Act 
            customer.Email = expectedEmail;

            //Assert
            Assert.Equal(expectedEmail, customer.Email);
        }

    }
}
