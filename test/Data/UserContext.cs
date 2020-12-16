using Microsoft.EntityFrameworkCore;

namespace test.Data
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<test.Models.User> User { get; set; }
    }
}
