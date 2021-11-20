using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportStore.Models.DAO.Interfaces
{
    public interface ICommentsAndLikesRepository
    {
        Task<IList<Comment>> GetCommentsAsync();
        Task<bool> AddLikeJunctionAsync(LikeJunction likeJunction);
    }
}