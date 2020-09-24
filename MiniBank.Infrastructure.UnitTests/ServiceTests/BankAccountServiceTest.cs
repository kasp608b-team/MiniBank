using System;
using System.Collections.Generic;
using System.Linq;
using MiniBank.Core.ApplicationService.Implementations;
using MiniBank.Core.ApplicationService.Interfaces;
using MiniBank.Core.DomainService;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;
using Xunit;
using Moq;

namespace MiniBank.Infrastructure.UnitTests.ServiceTests
{
    public class BankAccountServiceTest
    {
        private Dictionary<int, IBankAccount> dataStore;

        private Mock<IRepository<int, IBankAccount>> repoMock;

        public BankAccountServiceTest()
        {
            dataStore = new Dictionary<int, IBankAccount>();
            repoMock = new Mock<IRepository<int, IBankAccount>>();
            repoMock.Setup(x => x.Add(It.IsAny<IBankAccount>()))
                .Callback<IBankAccount>(acc => dataStore.Add(acc.BankAccountId, acc));
            repoMock.Setup(x => x.Remove(It.IsAny<IBankAccount>())).Callback<IBankAccount>((acc) =>
                dataStore.Remove(acc.BankAccountId));
            repoMock.Setup(x => x.GetById(It.IsAny<int>())).Returns<int>((accNum) =>
                dataStore.ContainsKey(accNum) ? dataStore[accNum] : null);
            repoMock.Setup(x => x.GetAll()).Returns(dataStore.Values.ToList);
        }

        [Fact]
        public void CreateBankAccountServiceTest()
        {
            IRepository<int, IBankAccount> repo = repoMock.Object;

            IBankAccountService bankAccountService = new BankAccountService(repo);

            Assert.Empty(dataStore);
        }

        [Fact]
        public void CreateBankAccountManagerMissingRepositoryExpectArgumentException()
        {
            IBankAccountService bankAccountService = null;

            // act + assert
            var ex = Assert.Throws<ArgumentException>(() => bankAccountService = new BankAccountService(null));

            Assert.Null(bankAccountService);
            Assert.Equal("Missing BankAccount Repository", ex.Message);
        }

        [Fact]
        public void AddNonExistingBankAccount()
        {

            IBankAccount acc = new BankAccount{BankAccountId = 1};

            IRepository<int, IBankAccount> repo = repoMock.Object;
            IBankAccountService bankAccountService = new BankAccountService(repo);

            // act
            bankAccountService.Add(acc);

            Assert.True(dataStore.Count == 1);
            Assert.Equal(acc, dataStore[1]);
        }

        [Fact]
        public void AddBankAccountIsNullExpectArgumentException()
        {
            IRepository<int, IBankAccount> repo = repoMock.Object;
            IBankAccountService bankAccountService = new BankAccountService(repo);

            // act + assert
            var ex = Assert.Throws<ArgumentException>(() => bankAccountService.Add(null));

            Assert.Equal("Bank account cannot be null", ex.Message);


        }

        [Fact]
        public void AddBankAccountAlreadyExistsExpectArgumentException()
        {
            IRepository<int, IBankAccount> repo = repoMock.Object;
            IBankAccountService bankAccountService = new BankAccountService(repo);
            IBankAccount acc = new BankAccount { BankAccountId = 1 };

            // act + assert
            bankAccountService.Add(acc);
            var ex = Assert.Throws<ArgumentException>(() => bankAccountService.Add(acc));

            Assert.Equal("This Bank account already exist in the repo", ex.Message);


        }

        [Fact]
        public void GetAllTest()
        {
            IBankAccount acc = new BankAccount { BankAccountId = 1, Balance = 100 };
            IBankAccount acc2 = new BankAccount { BankAccountId = 2, Balance = 110 };

            IRepository<int, IBankAccount> repo = repoMock.Object;
            IBankAccountService bankAccountService = new BankAccountService(repo);

            // act
            List<IBankAccount> excpectedList = new List<IBankAccount>();
            excpectedList.Add(acc);
            excpectedList.Add(acc2);
            bankAccountService.Add(acc);
            bankAccountService.Add(acc2);

            Assert.True(dataStore.Count == 2);
            Assert.Equal(excpectedList, bankAccountService.GetAll());

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

        [Fact]
        public void AddInterestTest()
        {

        }

        [Fact]
        public void DepositTest()
        {

        }

        [Fact]
        public void WithdrawTest()
        {

        }


    }
}