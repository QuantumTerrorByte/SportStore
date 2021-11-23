using System.Collections.Generic;
using System.Threading.Tasks;
using DAO.Models;

namespace DAO.Interfaces
{
    public interface ILikesRepository
    {
        Task<IList<LikeJunction>> GetLikesAsync(string authorId);
        Task<LikeJunction> AddLikeAsync(LikeJunction like);
        Task<LikeJunction> DeleteLikeAsync(long likeId);
    }
}