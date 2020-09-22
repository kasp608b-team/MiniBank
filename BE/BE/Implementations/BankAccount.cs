using System.Collections.Generic;
using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.Entities.BE.Implementations
{
    public class BankAccount : IBankAccount
    {
        public int BankAccountId { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public IList<CustomerBankAccount> CustomerBankAccounts { get; set; }
    }
}