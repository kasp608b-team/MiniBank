using System;

namespace BE
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime DateTimeOfTransaction { get; set; }
        public string Message { get; set; }
        public double Amount { get; set; }
    }
}