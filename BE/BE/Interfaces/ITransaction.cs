using System;

namespace MiniBank.Core.Entities.BE.Interfaces
{
    public interface ITransaction
    {
        public int TransactionId { get; }
        public DateTime DateTimeOfTransaction { get; }
        public string Message { get; }
        public double Amount { get; }
        public int ForeignKeyAccountNumber { get; }
    }
}