using MiniBank.Core.Entities.BE.Implementations;

namespace MiniBank.Core.Entities.BE.Interfaces
{
    public interface ICustomerBankAccount
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}