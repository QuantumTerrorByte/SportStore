using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface ICommentsAndLikesRepository
    {
        Task<IList<Comment>> GetCommentsAsync(string authorId);
        Task<IList<Comment>> GetCommentsAsync(long productId);
        Task<Comment> AddCommentAsync(Comment comment);
        Task<Comment> EditCommentAsync(Comment editedComment);
        Task<Comment> DeleteCommentAsync(long commentId);
    }
}