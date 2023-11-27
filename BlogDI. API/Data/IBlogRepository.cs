using BlogDI._API.Model;

namespace BlogDI._API.Data
{
    public interface IBlogRepository
    {
        List<Blog> getAllBlogs();
    }
}