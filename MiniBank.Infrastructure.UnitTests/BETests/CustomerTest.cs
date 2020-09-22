using System.Collections.Generic;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BETests
{
    public class CustomerTest
    {
        [Fact]
        public void CustomerIdSetGetTest()
        {
            //Arrange 
            ICustomer customer = new Customer();
            int expectedCustomerNumber = 1;

            //Act 
            customer.CustomerId = expectedCustomerNumber;

            //Assert
            Assert.Equal(expectedCustomerNumber, customer.CustomerId);
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

        [Fact]
        public void CustomerBankAccountsSetGetTest()
        {
            //Arrange 
            ICustomer customer = new Customer();
            IList<CustomerBankAccount> expectedCustomerBankAccounts = new List<CustomerBankAccount>();

            //Act 
            customer.CustomerBankAccounts = expectedCustomerBankAccounts;

            //Assert
            Assert.Equal(expectedCustomerBankAccounts, customer.CustomerBankAccounts);
        }

    }
}
