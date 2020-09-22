using System.Collections.Generic;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BETests
{
    public class BankAccountTest
    {
        [Fact]
        public void BankAccountIdSetGetTest()
        {
            //Arrange 
            IBankAccount bankAccount = new BankAccount();
            int expectedBankAccountId = 1;

            //Act 
            bankAccount.BankAccountId = expectedBankAccountId;

            //Assert
            Assert.Equal(expectedBankAccountId, bankAccount.BankAccountId);
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


        [Fact]
        public void CustomerBankAccountsSetGetTest()
        {
            //Arrange 
            IBankAccount bankAccount = new BankAccount();
            IList<CustomerBankAccount> expectedBankAccounts = new List<CustomerBankAccount>();

            //Act 
            bankAccount.CustomerBankAccounts = expectedBankAccounts;

            //Assert
            Assert.Equal(expectedBankAccounts, bankAccount.CustomerBankAccounts);
        }
    }
}
