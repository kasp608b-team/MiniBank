using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.Entities.BE.Implementations
{
    public class Customer_BankAccount : ICustomer_BankAccount
    {
        public int ForeignKeyAccountNumber { get; set; }
        public int ForeignKeyCustomerNumber { get; set; }
    }
}