using WpBlog.model;
using WpBlog.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WpBlog.Controller
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    //ControllerBase: Usado para controlar a base dos dados, convertendo para o http;
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository postRepository)
        {   
            _postRepository = postRepository;
        }

        //HttpGet: acessado via http
        [HttpGet]
        //typeof: Dado bruto > Model > Json
        [Produces(typeof(post))]
        public IActionResult Get()
        {
            var posts = _postRepository.GetAll();
            if (posts.Count() == 0)
                return NoContent();
            return Ok(posts);
        }
    }
}