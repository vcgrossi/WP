using System.Collections.Generic;
using WpBlog.model;
using System;
using System.Linq;
using wpBlog.Repository;

namespace WpBlog.Repository
{
    public class postRepository : IPostRepository
    {
        public IEnumerable<post> GetAll()
        {
            try
            {
                using (var db = new webPixContext())
                {
                    return db.post.Where(x => x.Ativo == true).ToList();
                }
            }
            catch (Exception e)
            {
                ////
                return new List<post>();
            }

        }

    }
}