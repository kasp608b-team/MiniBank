namespace MiniBank.Core.Entities.BE.Interfaces
{
    public interface IBankAccount
    {
        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
    }
}