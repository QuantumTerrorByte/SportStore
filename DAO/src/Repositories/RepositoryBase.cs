using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext DataContext { get;  }
        protected DbSet<T> DbSet { get;  }

        public RepositoryBase(DataContext dataContext)
        {
            DataContext = dataContext;
            DbSet = dataContext.Set<T>();
        }

        public async Task<T> Get<TKey>(TKey key)
        {
            return await DbSet.FindAsync(key);
        }

        public async Task Add(T entity)
        {
            DbSet.Add(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task Edit(T entity)
        {
            DbSet.Update(entity);
            await DataContext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            DbSet.Remove(entity);
            await DataContext.SaveChangesAsync();
        }
    }
}