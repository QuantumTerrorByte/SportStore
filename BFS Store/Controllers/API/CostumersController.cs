using System;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers.API
{
    [DisableCors]
    [Route("[controller]")]
    [ApiController]
    public class CostumersController : ControllerBase
    {
        private readonly IAppUsersRepository _usersRepository;
        private readonly IProductRepository _productRepository;

        public CostumersController(IAppUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost]
        [Route("[action]")]
        // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> AddLike(long productId)
        {
            try
            {
                var product = await _productRepository.GetProduct(productId);
                if (product == null) return BadRequest("Unknown product id");
                
                var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "id");
                if (userId == null) return BadRequest("Unknown user");

                var user = await _usersRepository.GetAsync(userId.Value);
                if (user == null) return BadRequest("Unknown user");

                user.Likes.Add(product);
                await _usersRepository.EditAsync(user);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Bd issue");
            }
        }

        // GET: api/Users
        [HttpGet]
        [Route("[action]")]
        public IActionResult Create(string name, string id, string email)
        {
            var user = new AppUser {Id = id, UserName = name, Email = email};
            try
            {
                _usersRepository.AddAsync(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }

            return Ok();
        }
    }
}