namespace MiniBank.Core.Entities.BE.Interfaces
{
    public interface ICustomer_BankAccount
    {
        public int ForeignKeyAccountNumber { get; set; }
        public int ForeignKeyCustomerNumber { get; set; }
    }
}