using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BETests
{
    public class CustomerBankAccountTest
    {
        [Fact]
        public void BankAccountIdSetGetTest()
        {
            //Arrange 
            ICustomerBankAccount customerBankAccount = new CustomerBankAccount();
            int expectedBankAccountId = 1;

            //Act 
            customerBankAccount.BankAccountId = expectedBankAccountId;

            //Assert
            Assert.Equal(expectedBankAccountId, customerBankAccount.BankAccountId);
        }

        [Fact]
        public void BankAccountSetGetTest()
        {
            //Arrange 
            ICustomerBankAccount customerBankAccount = new CustomerBankAccount();
            BankAccount expectedBankAccount = new BankAccount();

            //Act 
            customerBankAccount.BankAccount = expectedBankAccount;

            //Assert
            Assert.Equal(expectedBankAccount, customerBankAccount.BankAccount);
        }

        [Fact]
        public void CustomerIdSetGetTest()
        {
            //Arrange 
            ICustomerBankAccount customerBankAccount = new CustomerBankAccount();
            int expectedCustomerId = 1;

            //Act 
            customerBankAccount.CustomerId = expectedCustomerId;

            //Assert
            Assert.Equal(expectedCustomerId, customerBankAccount.CustomerId);
        }

        [Fact]
        public void CustomerSetGetTest()
        {
            //Arrange 
            ICustomerBankAccount customerBankAccount = new CustomerBankAccount();
            Customer expectedCustomer = new Customer();

            //Act 
            customerBankAccount.Customer = expectedCustomer;

            //Assert
            Assert.Equal(expectedCustomer, customerBankAccount.Customer);
        }
    }
}