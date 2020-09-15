using System;

namespace MiniBank.Core.Entities.BE.Interfaces
{
    public interface ITransaction
    {
        public int TransactionId { get; set; }
        public DateTime DateTimeOfTransaction { get; set; }
        public string Message { get; set; }
        public double Amount { get; set; }
        public int ForeignKeyAccountNumber { get; set; }
    }
}