using System;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;

namespace MiniBank.Infrastructure.UnitTests.BE
{
    public class TransactionTest
    {
        [Fact]
        public void AccountNumberGetTest()
        {
            //Arrange 
            int expectedId = 1;
            ITransaction transaction = new Transaction(expectedId, DateTime.Now, "test", 10, 1);

            //Act 
            

            //Assert
            Assert.Equal(expectedId, transaction.TransactionId);
        }

        [Fact]
        public void DateTimeOfTransactionSetGetTest()
        {
            //Arrange 
            DateTime expectedDateTime = DateTime.Now;
            ITransaction transaction = new Transaction(1, expectedDateTime, "test", 10, 1);

            //Act 

            //Assert
            Assert.Equal(expectedDateTime, transaction.DateTimeOfTransaction);
        }

        [Fact]
        public void MessageSetGetTest()
        {
            //Arrange 
            string expectedMessage = "test message";
            ITransaction transaction = new Transaction(1, DateTime.Now, expectedMessage, 10, 1);

            //Act 

            //Assert
            Assert.Equal(expectedMessage, transaction.Message);
        }

        [Fact]
        public void AmountSetGetTest()
        {
            //Arrange 
            int expectedAmount = 25;
            ITransaction transaction = new Transaction(1, DateTime.Now, "test", expectedAmount, 1);

            //Act 

            //Assert
            Assert.Equal(expectedAmount, transaction.Amount);
        }

        [Fact]
        public void ForeignKeyAccountNumberSetGetTest()
        {
            //Arrange 
            int expectedForeignKeyAccountNumber = 1;
            ITransaction transaction = new Transaction(1, DateTime.Now, "test", 10, expectedForeignKeyAccountNumber);

            //Act 

            //Assert
            Assert.Equal(expectedForeignKeyAccountNumber, transaction.ForeignKeyAccountNumber);
        }

    }
}