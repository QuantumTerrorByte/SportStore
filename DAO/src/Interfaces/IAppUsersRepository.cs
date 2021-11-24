using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;
using DAO.Repositories;

namespace DAO.Interfaces
{
    public interface IAppUsersRepository :  IRepositoryBase<AppUser>
    {
        Task<List<AppUser>> GetWithInclude();
    }
}