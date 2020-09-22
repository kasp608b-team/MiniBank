using System.Collections.Generic;
using MiniBank.Core.DomainService;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;
using Moq;

namespace MiniBank.Infrastructure.UnitTests.ServiceTests
{
    public class BankAccountServiceTest
    {
        [Fact]
        public void AddTest()
        {
            IBankAccount bankAccount = new BankAccount();
            var mock = new Mock<IRepository<IBankAccount>>();
            mock.Setup(repository => repository.Add(bankAccount)).Returns(new BankAccount());
        }

        [Fact]
        public void GetAllTest()
        {

        }

        [Fact]
        public void GetByIdTest()
        {

        }

        [Fact]
        public void UpdateTest()
        {

        }

        [Fact]
        public void RemoveTest()
        {

        }
    }
}