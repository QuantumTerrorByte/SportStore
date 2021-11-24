using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class CommentsRepository : RepositoryBase<Comment>, ICommentsRepository
    {
        private readonly DataContext _context;

        public CommentsRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IList<Comment>> GetByAuthorIdAsync(string authorId)
        {
            return await _context.Comments.Where(c => c.AuthorId == authorId).ToListAsync();
        }

        public async Task<IList<Comment>> GetByProductIdAsync(long productId)
        {
            return await _context.Comments.Where(c => c.ProductId == productId).ToListAsync();//todo prod id
        }
    }
}