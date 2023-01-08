using Microsoft.EntityFrameworkCore;

namespace productwebsitedotnetcore.Entities
{
    //core ile null alabilmesi için kesinlikle ? stringde olsa

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
