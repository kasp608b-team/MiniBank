using MiniBank.Core.Entities.BE.Interfaces;

namespace MiniBank.Core.Entities.BE.Implementations
{
    public class Customer : ICustomer
    {
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string  Email { get; set; }
        
    }
}