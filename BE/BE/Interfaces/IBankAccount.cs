using System.Collections.Generic;
using MiniBank.Core.Entities.BE.Implementations;

namespace MiniBank.Core.Entities.BE.Interfaces
{
    public interface IBankAccount
    {
        public int BankAccountId { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public IList<CustomerBankAccount> CustomerBankAccounts { get; set; }
    }
}