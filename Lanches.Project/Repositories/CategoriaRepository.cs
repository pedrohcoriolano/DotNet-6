using Lanches.Project.Context;
using Lanches.Project.Models;
using Lanches.Project.Repositories.Interfaces;

namespace Lanches.Project.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
