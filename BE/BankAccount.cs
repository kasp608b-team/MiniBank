using System.Collections.Generic;

namespace BE
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public List<Transaction> ListOfTransactions { get; set; }    
                
    }
}