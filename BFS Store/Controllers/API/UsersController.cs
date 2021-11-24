using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Interfaces;
using DAO.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace SportStore.Controllers.API
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAppUsersRepository _usersRepository;
        private readonly IProductRepository _productRepository;

        public UsersController(IAppUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpPost]
        [Route("[action]")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> AddLike(long productId)
        {
            try
            {
                var product = await _productRepository.GetProduct(productId);
                if (product == null) return BadRequest("Unknown product id");
                
                var userId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "id");
                if (userId == null) return BadRequest("Unknown user");

                var user = await _usersRepository.Get(userId.Value);
                if (user == null) return BadRequest("Unknown user");

                user.Likes.Add(product);
                await _usersRepository.Edit(user);
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
                _usersRepository.Add(user);
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