using System.Collections.Generic;
using DAO.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers.API
{
    [Route("[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentsRepository _commentsRepository;
        private readonly IAppUsersRepository _usersRepository;

        public CommentController(ICommentsRepository commentsRepository, IAppUsersRepository usersRepository)
        {
            _commentsRepository = commentsRepository;
            _usersRepository = usersRepository;
        }

        // GET: api/Comment
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Comment
        [HttpPost]
        public void Post([FromBody] CommentViewModel commentViewModel)
        {
            
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public void Edit(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
