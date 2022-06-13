using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models.DataAccess
{
    public class UserManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK25;Initial Catalog=UserManagement;Integrated Security=True");
        }
    }
}
