using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class AppUsersRepository : RepositoryBase<AppUser>, IAppUsersRepository
    {
        public static readonly object AppUserSyncObj  = new object();                                                                                                                               

        public AppUsersRepository(AppDataContext appDataContext) : base(appDataContext)
        {
        }

        public async Task<List<AppUser>> GetWithInclude()
        {
            return await DbSet.AsNoTracking()
                .Include(user => user.Address)
                .Include(user => user.Likes)
                .ToListAsync();
        }
    }
}