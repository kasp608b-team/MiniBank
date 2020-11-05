using System;
using System.Collections.Generic;
using MiniBank.Core.ApplicationService.Interfaces;
using MiniBank.Core.DomainService;
using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.ApplicationService.Implementations
{
    //Sklep
    public class BankAccountService : IBankAccountService
    {
        private readonly IRepository<int , IBankAccount> _repository;

        public BankAccountService(IRepository<int, IBankAccount> repository)
        {
            _repository = repository ?? throw new ArgumentException("Missing BankAccount Repository");
        }

        public IBankAccount Add(IBankAccount obj)
        {
            IBankAccount bankAccountToAdd = obj ?? throw new ArgumentException("Bank account cannot be null");


            if (_repository.GetById(obj.BankAccountId) != null)
            {
                throw new ArgumentException("This Bank account already exist in the repo");
            }

            return _repository.Add(bankAccountToAdd);
        }

        public List<IBankAccount> GetAll()
        {
            return _repository.GetAll();
        }

        public IBankAccount GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IBankAccount Update(IBankAccount obj)
        {
            throw new NotImplementedException();
        }

        public IBankAccount Remove(IBankAccount obj)
        {
            throw new NotImplementedException();
        }

        public void AddInterest()
        {
            throw new NotImplementedException();
        }

        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }

        public void TransferAmount(IBankAccount fromAccount, IBankAccount toAccount, double amount)
        {
            throw new NotImplementedException();
        }

        public void AddInterestToAllAccounts()
        {
            throw new NotImplementedException();
        }
    }
}