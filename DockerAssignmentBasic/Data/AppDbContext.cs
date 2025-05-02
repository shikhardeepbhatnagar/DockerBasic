using DockerAssignmentBasic.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerAssignmentBasic.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
