using KASHOP.DAl.Moadels;
using Microsoft.EntityFrameworkCore;

namespace KASHOP.DAl.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categores> Catgores { get; set; }
    }
}
