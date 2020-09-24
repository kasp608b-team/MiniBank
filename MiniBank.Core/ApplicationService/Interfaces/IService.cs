using System.Collections.Generic;

namespace MiniBank.Core.ApplicationService.Interfaces
{
    public interface IService<k , t>
    {
        public t Add(t obj);
        public List<t> GetAll();
        public t GetById(k id);
        public t Update(t obj);
        public t Remove(t obj);

    }
}