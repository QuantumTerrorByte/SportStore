using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class AppUsersRepository : RepositoryBase<AppUser>, IAppUsersRepository
    {
        public AppUsersRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public async Task<List<AppUser>> GetWithInclude()
        {
            return await DbSet.AsNoTracking()
                .Include(user => user.Addresses)
                .Include(user => user.Likes)
                .ToListAsync();
        }
    }
}