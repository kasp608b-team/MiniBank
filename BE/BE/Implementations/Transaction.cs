using System;
using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.Entities.BE.Implementations
{
    public class Transaction : ITransaction
    {
        public int TransactionId { get; set; }
        public DateTime DateTimeOfTransaction { get; set; }
        public string Message { get; set; }
        public double Amount { get; set; }
        public int ForeignKeyAccountNumber { get; set; }
    }
}