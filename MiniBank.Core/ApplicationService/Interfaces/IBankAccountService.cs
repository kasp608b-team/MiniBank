using MiniBank.Core.Entities.BE.Implementations;
using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.ApplicationService.Interfaces
{
    public interface IBankAccountService : IService<int, IBankAccount>
    {
        public void AddInterest();
        public void Deposit(double amount);
        public void Withdraw(double amount);

        // Transfers the given amount from account1 to account2.
        public void TransferAmount(IBankAccount fromAccount, IBankAccount toAccount, double amount);
        // Adds interest to all BankAccounts in the system.
        public void AddInterestToAllAccounts();
    }
}