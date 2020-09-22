using System.Collections.Generic;

namespace MiniBank.Core.DomainService
{
    public interface IRepository<t>
    {
        public t Add(t obj);
        public IEnumerable<t> GetAll();
        public t GetById(int id);
        public t Update(t obj);
        public t Remove(t obj);
    }
}