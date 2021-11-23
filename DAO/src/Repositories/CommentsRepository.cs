using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace DAO.Repositories
{
    public class CommentsRepository : ICommentsAndLikesRepository
    {
        private readonly DataContext _context;

        public CommentsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IList<Comment>> GetCommentsAsync(string authorId)
        {
            return await _context.Comments.Where(c => c.AuthorId == authorId).ToListAsync();
        }

        public async Task<IList<Comment>> GetCommentsAsync(long productId)
        {
            return await _context.Comments.Where(c => c.ProductId == productId).ToListAsync();//todo prod id
        }

        public async Task<Comment> AddCommentAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<Comment> EditCommentAsync(Comment editedComment)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Comment> DeleteCommentAsync(long commentId)
        {
            var delete = await _context.Comments.FindAsync(commentId);
            if (delete == null)
            {
                return null;
            }

            _context.Comments.Remove(delete);
            await _context.SaveChangesAsync();
            return delete;
        }
    }
}