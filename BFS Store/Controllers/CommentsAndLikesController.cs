using DAO.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class CommentsAndLikesController : Controller
    {
        private readonly ICommentsRepository _commentsRepository;
        private readonly IProductRepository _productRepository;

        public CommentsAndLikesController(ICommentsRepository commentsRepository,
            IProductRepository productRepository)
        {
            _commentsRepository = commentsRepository;
            _productRepository = productRepository;
        }

        // [Authorize(JwtBearerDefaults.AuthenticationScheme, Policy = "user")]
        // public async Task<IActionResult> Comments()
        // {
        //     return Ok();
        // }
        
        // [Authorize(JwtBearerDefaults.AuthenticationScheme, Policy = "user")]
        // public async Task<IActionResult> Likes()
        // {
        //     var userId = HttpContext.User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value;
        //     if (string.IsNullOrEmpty(userId))
        //     {
        //         return Unauthorized("user id undefined");
        //     }
        //     var user = await _userManager.FindByIdAsync(userId);
        //     if (user==null)
        //     {
        //         return Unauthorized("user id undefined");
        //     }
        //
        //     var likes = user.Likes.Select(lj=> lj.Product);
        //     return Ok(likes);
        // }
        //
        // [Authorize(JwtBearerDefaults.AuthenticationScheme, Policy = "user")]
        // public async Task<IActionResult> SetLike(long productId)
        // {
        //     var userId = HttpContext.User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value;
        //     var userEmail = HttpContext.User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)?.Value;
        //     if (string.IsNullOrEmpty(userId))
        //     {
        //         return Unauthorized("user id undefined");
        //     }
        //
        //     var taskUser = _userManager.FindByIdAsync(userId);
        //     var taskProduct = _productRepository.GetProduct(productId);
        //     var user = await taskUser;
        //     var product = await taskProduct;
        //
        //     if (user == null || product == null)
        //     {
        //         return BadRequest();
        //     }
        //
        //     var likeJunction = new LikeJunction {Product = product, AppUser = user};
        //     var addResult = await _commentsAndLikesRepository.AddLikeJunctionAsync(likeJunction);
        //     return Ok();
        // }
    }
}