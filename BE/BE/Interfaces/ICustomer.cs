using System.Collections.Generic;
using MiniBank.Core.Entities.BE.Implementations;

namespace MiniBank.Core.Entities.BE.Interfaces
{
    public interface ICustomer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IList<CustomerBankAccount> CustomerBankAccounts { get; set; }
    }
}