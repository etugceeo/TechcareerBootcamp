using Womanlike.Entity;
using Microsoft.EntityFrameworkCore;

namespace Womanlike.Data.Concrete.EfCore
{
    public class BContext:DbContext{
        public BContext(DbContextOptions<BContext> options):base(options)
        {

        }
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Topic> Topics => Set<Topic>();
        public DbSet<User> Users => Set<User>();

    }
}