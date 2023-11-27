using BlogDI._API.Data;
using BlogDI._API.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogDI._API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        // data ganne mona location ekend kiyann oni 

        BlogRepository  repository = new BlogRepository();

        // GET: api/<BlogsController>
        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            var blogs = repository.getAllBlogs();
            return Ok(blogs);
        }

    }
}
