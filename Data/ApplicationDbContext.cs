using Microsoft.EntityFrameworkCore;

namespace WebApplicationExemplo01.Data
{
    public class ApplicationDbContext : DbContext{
    

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
            ) : base(options) { }

        public DbSet<Produto> Produto { get; set; } = default!;

    }
}
