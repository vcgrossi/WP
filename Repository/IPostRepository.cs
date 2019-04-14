using System.Collections.Generic;
using WpBlog.model;

namespace WpBlog.Repository
{
    public interface IPostRepository 
    {
        IEnumerable<post> GetAll();    
    }
}