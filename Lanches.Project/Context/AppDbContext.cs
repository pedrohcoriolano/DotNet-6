using Lanches.Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Project.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Lanche> Lanches { get; set; }

    }
}
