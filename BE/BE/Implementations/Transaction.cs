using System;
using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.Entities.BE.Implementations
{
    public class Transaction : ITransaction
    {
        public Transaction(int transactionId, DateTime dateTimeOfTransaction, string message, double amount, int foreignKeyAccountNumber)
        {
            TransactionId = transactionId;
            DateTimeOfTransaction = dateTimeOfTransaction;
            Message = message;
            Amount = amount;
            ForeignKeyAccountNumber = foreignKeyAccountNumber;
        }

        public int TransactionId { get; }
        public DateTime DateTimeOfTransaction { get; }
        public string Message { get; }
        public double Amount { get; }
        public int ForeignKeyAccountNumber { get; }
    }
}