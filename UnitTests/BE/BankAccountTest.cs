using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BE
{
    public class BankAccountTest
    {
        [Fact]
        public void AccountNumberSetGetTest()
        {
            //Arrange 
            IBankAccount bankAccount = new BankAccount();
            int expectedAccountNumber = 1;

            //Act 
            bankAccount.AccountNumber = expectedAccountNumber;

            //Assert
            Assert.Equal(expectedAccountNumber, bankAccount.AccountNumber);
        }

        [Fact]
        public void InterestRateSetGetTest()
        {
            //Arrange 
            IBankAccount bankAccount = new BankAccount();
            double expectedInterestRate = 0.10; 

            //Act 
            bankAccount.InterestRate = expectedInterestRate;

            //Assert
            Assert.Equal(expectedInterestRate, bankAccount.InterestRate);
        }

        [Fact]
        public void BalanceSetGetTest()
        {
            //Arrange 
            IBankAccount bankAccount = new BankAccount();
            double expectedBalance = 100.10;

            //Act 
            bankAccount.Balance = expectedBalance;

            //Assert
            Assert.Equal(expectedBalance, bankAccount.Balance);
        }
    }
}
