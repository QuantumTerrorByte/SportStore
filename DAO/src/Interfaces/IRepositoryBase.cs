using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAO.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> GetAsync<TKey>(TKey key);

        Task<List<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task<T> EditAsync(T entity);

        Task<T> DeleteAsync(T entity);

        T Get<TKey>(TKey key, bool withInclude = false);
        List<T> GetAll();
        T Add(T entity);
        T Edit(T entity);
        T Delete(T entity);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}