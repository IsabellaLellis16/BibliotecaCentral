using Microsoft.EntityFrameworkCore;
using BibliotecaCentral.Models;

namespace BibliotecaCentral.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
