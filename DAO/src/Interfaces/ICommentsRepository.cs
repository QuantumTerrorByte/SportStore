using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface ICommentsRepository : IRepositoryBase<Comment>
    {
        public static object CommentsSyncObj { get; } = new();

        Task<IList<Comment>> GetByAuthorIdAsync(string authorId);
        Task<IList<Comment>> GetByProductIdAsync(long productId);
    }
}