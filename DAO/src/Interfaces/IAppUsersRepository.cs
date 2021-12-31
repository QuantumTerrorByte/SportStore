using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;
using DAO.Repositories;

namespace DAO.Interfaces
{
    public interface IAppUsersRepository :  IRepositoryBase<AppUser>
    {
        public static readonly object AppUserSyncObj  = new object();
        Task<List<AppUser>> GetWithInclude();
    }
}