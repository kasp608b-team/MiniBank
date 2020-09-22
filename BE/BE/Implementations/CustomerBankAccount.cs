using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.Entities.BE.Implementations
{
    public class CustomerBankAccount : ICustomerBankAccount
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}