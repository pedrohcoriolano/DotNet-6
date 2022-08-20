using Lanches.Project.Context;
using Lanches.Project.Models;
using Lanches.Project.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Project.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(x => x.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
            return _context.Lanches.FirstOrDefault(x => x.LancheId == id);
        }
    }
}
