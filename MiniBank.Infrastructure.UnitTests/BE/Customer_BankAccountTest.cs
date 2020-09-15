using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BE
{
    public class Customer_BankAccountTest
    {
        [Fact]
        public void AccountNumberSetGetTest()
        {
            //Arrange 
            ICustomer_BankAccount customerBankAccount = new Customer_BankAccount();
            int expectedForeignKeyAccountNumber = 1;

            //Act 
            customerBankAccount.ForeignKeyAccountNumber = expectedForeignKeyAccountNumber;

            //Assert
            Assert.Equal(expectedForeignKeyAccountNumber, customerBankAccount.ForeignKeyAccountNumber);
        }

        [Fact]
        public void CustomerNumberSetGetTest()
        {
            //Arrange 
            ICustomer_BankAccount customerBankAccount = new Customer_BankAccount();
            int expectedForeignKeyCustomerNumber = 1;

            //Act 
            customerBankAccount.ForeignKeyCustomerNumber = expectedForeignKeyCustomerNumber;

            //Assert
            Assert.Equal(expectedForeignKeyCustomerNumber, customerBankAccount.ForeignKeyCustomerNumber);
        }
    }
}