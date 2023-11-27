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
        private readonly IBlogRepository _repository; // me kotasa auto enawa, constructor eka 
        // create kral parameters dila, ctrl + . gahala ena eken select karal dunnam 
        public BlogsController(IBlogRepository repository)
        {
            _repository = repository;
        }

        // data ganne mona location ekend kiyann oni 

       // BlogRepository  repository = new BlogRepository();  // create a new repository. constructor eken hadnwa nam meka oni na 
        

        // GET: api/<BlogsController>
        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            var blogs = _repository.getAllBlogs();
            return Ok(blogs);
        }

    }
}
