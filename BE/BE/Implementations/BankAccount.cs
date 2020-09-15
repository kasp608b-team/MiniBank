using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.Entities.BE.Implementations
{
    public class BankAccount : IBankAccount
    {
        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; } 
                
    }
}