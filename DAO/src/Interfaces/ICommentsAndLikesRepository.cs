using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface ICommentsAndLikesRepository
    {
        Task<IList<Comment>> GetCommentsAsync();
        Task<bool> AddLikeJunctionAsync(LikeJunction likeJunction);
    }
}