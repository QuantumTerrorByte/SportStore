using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface ICommentsRepository: IRepositoryBase<Comment>
    {
        Task<IList<Comment>> GetByAuthorIdAsync(string authorId);
        Task<IList<Comment>> GetByProductIdAsync(long productId);
    }
}