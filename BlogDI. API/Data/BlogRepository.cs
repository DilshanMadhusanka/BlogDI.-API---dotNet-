using BlogDI._API.Model;

namespace BlogDI._API.Data
{
    public class BlogRepository
    {
        // create a blog list ( this is our data set now => because stil we donot have data base )

        public static List<Blog> blogs = new List<Blog>() 
        {
            new Blog(){ Id = 1 ,Content ="this is five episodes", 
                Title =" time newroman  " },

            new Blog(){ Id = 2 ,Content ="nine episodes",
                Title =" the dragon " },

            new Blog(){ Id = 3 ,Content ="seven episodes",
                Title =" lover the best " },
        };


        public List<Blog> getAllBlogs() 
        { 
            return blogs;
        }
    }
}
