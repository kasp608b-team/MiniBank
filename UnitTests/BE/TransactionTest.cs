using System;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BE
{
    public class TransactionTest
    {
        [Fact]
        public void AccountNumberSetGetTest()
        {
            //Arrange 
            ITransaction transaction = new Transaction();
            int expectedId = 1;

            //Act 
            transaction.TransactionId = expectedId;

            //Assert
            Assert.Equal(expectedId, transaction.TransactionId);
        }

        [Fact]
        public void DateTimeOfTransactionSetGetTest()
        {
            //Arrange 
            ITransaction transaction = new Transaction();
            DateTime expectedDateTime = DateTime.Now;

            //Act 
            transaction.DateTimeOfTransaction = expectedDateTime;

            //Assert
            Assert.Equal(expectedDateTime, transaction.DateTimeOfTransaction);
        }

        [Fact]
        public void MessageSetGetTest()
        {
            //Arrange 
            ITransaction transaction = new Transaction();
            string expectedMessage = "test message";

            //Act 
            transaction.Message = expectedMessage;

            //Assert
            Assert.Equal(expectedMessage, transaction.Message);
        }

        [Fact]
        public void AmountSetGetTest()
        {
            //Arrange 
            ITransaction transaction = new Transaction();
            int expectedAmount = 25;

            //Act 
            transaction.Amount = expectedAmount;

            //Assert
            Assert.Equal(expectedAmount, transaction.Amount);
        }

        [Fact]
        public void ForeignKeyAccountNumberSetGetTest()
        {
            //Arrange 
            ITransaction transaction = new Transaction();
            int expectedForeignKeyAccountNumber = 1;

            //Act 
            transaction.ForeignKeyAccountNumber = expectedForeignKeyAccountNumber;

            //Assert
            Assert.Equal(expectedForeignKeyAccountNumber, transaction.ForeignKeyAccountNumber);
        }

    }
}