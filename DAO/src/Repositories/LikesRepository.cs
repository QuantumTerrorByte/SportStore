using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Core;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class LikesRepository : ILikesRepository
    {
        public static readonly SyncObj LikesSyncObj  = new SyncObj();
        private readonly AppDataContext _context;

        public LikesRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task<IList<LikeJunction>> GetLikesAsync(string authorId)
        {
            return await _context.LikeJunctions.Where(l => l.UserId == authorId).ToListAsync();
        }

        public async Task<LikeJunction> AddLikeAsync(LikeJunction like)
        {
            await _context.LikeJunctions.AddAsync(like);
            await _context.SaveChangesAsync();
            return like;
        }

        public async Task<LikeJunction> DeleteLikeAsync(long likeId)
        {
            var delete = await _context.LikeJunctions.FindAsync(likeId);
            if (delete == null)
            {
                return null;
            }
            _context.LikeJunctions.Remove(delete);
            await _context.SaveChangesAsync();
            return delete;
        }

    }
}