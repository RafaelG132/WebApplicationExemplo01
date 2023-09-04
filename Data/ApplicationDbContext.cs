using Microsoft.EntityFrameworkCore;
using WebApplicationExemplo01.Models;

namespace WebApplicationExemplo01.Data
{
    public class ApplicationDbContext : DbContext{
    

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){
        }

        public DbSet <Alunos> alunos { get; set; } = default!;
        public DbSet <Turma> turmas { get; set; } = default!;

    }
}
