using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService.Interfaces
{
    public interface IService<t>
    {
        public t Add(t obj);
        public IEnumerable<t> GetAll();
        public t GetById(int id);
        public t Update(t obj);
        public t Remove(t obj);

    }
}