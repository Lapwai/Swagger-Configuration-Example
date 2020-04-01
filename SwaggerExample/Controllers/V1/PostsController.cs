using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwaggerExample.Contracts;
using SwaggerExample.Contracts.V1;
using SwaggerExample.Domain;

namespace SwaggerExample.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();
            for (var i=0;i<5;i++) {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }


        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }
    }
}