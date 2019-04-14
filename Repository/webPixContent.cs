using WpBlog.model;
using Microsoft.EntityFrameworkCore;

namespace wpBlog.Repository
{
    public class webPixContext : DbContext
    {
        public DbSet<post> post { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer(@"Data Source=35.198.27.36;Initial Catalog=WpBlog;Persist Security Info=True;User ID=Dev;Password=WebPix@123;");
        }
    }
}