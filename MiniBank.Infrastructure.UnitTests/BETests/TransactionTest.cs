using System;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BETests
{
    public class TransactionTest
    {
        [Fact]
        public void AccountNumberGetTest()
        {
            //Arrange 
            int expectedId = 1;
            ITransaction transaction = new Transaction();

            //Act 
            transaction.TransactionId = expectedId;

            //Assert
            Assert.Equal(expectedId, transaction.TransactionId);
        }

        [Fact]
        public void DateTimeOfTransactionSetGetTest()
        {
            //Arrange 
            DateTime expectedDateTime = DateTime.Now;
            ITransaction transaction = new Transaction();

            //Act 
            transaction.DateTimeOfTransaction = expectedDateTime;

            //Assert
            Assert.Equal(expectedDateTime, transaction.DateTimeOfTransaction);
        }

        [Fact]
        public void MessageSetGetTest()
        {
            //Arrange 
            string expectedMessage = "test message";
            ITransaction transaction = new Transaction();

            //Act 
            transaction.Message = expectedMessage;

            //Assert
            Assert.Equal(expectedMessage, transaction.Message);
        }

        [Fact]
        public void AmountSetGetTest()
        {
            //Arrange 
            int expectedAmount = 25;
            ITransaction transaction = new Transaction();

            //Act 
            transaction.Amount = expectedAmount;

            //Assert
            Assert.Equal(expectedAmount, transaction.Amount);
        }

        [Fact]
        public void BankAccountSetGetTest()
        {
            //Arrange 
            BankAccount expectedBankAccount = new BankAccount();
            ITransaction transaction = new Transaction();

            //Act 
            transaction.BankAccount = expectedBankAccount;

            //Assert
            Assert.Equal(expectedBankAccount, transaction.BankAccount);
        }

    }
}