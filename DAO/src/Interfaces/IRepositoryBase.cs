using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
         Task<T> Get<TKey>(TKey key);
         
         Task Add(T entity);

         Task Edit(T entity);

         Task Delete(T entity);
    }
}