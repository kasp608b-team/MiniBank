using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{
    public interface IRepository<k , t>
    {
        public t Add(t obj);
        public List<t> GetAll();
        public t GetById(k id);
        public t Update(t obj);
        public t Remove(t obj);
    }
}