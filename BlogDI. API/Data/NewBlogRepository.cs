using BlogDI._API.Model;

namespace BlogDI._API.Data
{
    public class NewBlogRepository :IBlogRepository  // this is inherited 
    {
        public static List<Blog> blogs = new List<Blog>()
        {
            new Blog(){ Id = 100 ,Content ="this is five episodes",
                Title =" time newroman  " },

            new Blog(){ Id = 200 ,Content ="nine episodes",
                Title =" the dragon " },

            new Blog(){ Id = 300 ,Content ="seven episodes",
                Title =" lover the best " },
        };


        public List<Blog> getAllBlogs()
        {
            return blogs;
        }
    }
}
