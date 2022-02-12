using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDataContext AppDataContext { get; }
        protected DbSet<T> DbSet { get; }

        public RepositoryBase(AppDataContext appDataContext)
        {
            AppDataContext = appDataContext;
            DbSet = appDataContext.Set<T>();
        }

        public virtual async Task<T> GetFirstAsync()
        {
            return await DbSet.FirstOrDefaultAsync();
        }

        public virtual async Task<T> GetAsync<TKey>(TKey key)
        {
            return await DbSet.FindAsync(key);
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            DbSet.Add(entity);
            await AppDataContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> EditAsync(T entity)
        {
            DbSet.Update(entity);
            await AppDataContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
            await AppDataContext.SaveChangesAsync();
            return entity;
        }

        public virtual T Get<TKey>(TKey key, bool withInclude = false)
        {
            return DbSet.Find(key);
        }

        public virtual List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual T Add(T entity)
        {
            DbSet.Add(entity);
            AppDataContext.SaveChanges();
            return entity;
        }

        public virtual T Edit(T entity)
        {
            DbSet.Update(entity);
            AppDataContext.SaveChanges();
            return entity;
        }

        public virtual T Delete(T entity)
        {
            DbSet.Remove(entity);
            AppDataContext.SaveChanges();
            return entity;
        }

        public void SaveChanges()
        {
            AppDataContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await AppDataContext.SaveChangesAsync();
        }
    }
}