using Microsoft.EntityFrameworkCore;
using SandwichApp.Context;
using SandwichApp.Models;
using SandwichApp.Repositories.Interfaces;

namespace SandwichApp.Repositories
{
    public class SandwichRepository : ISandwichRepository
    {
        private readonly SandwichContext _context;

        public SandwichRepository(SandwichContext context)
        {
            _context = context;
        }

        public IEnumerable<Sandwich> Sandwiches => _context.Sandwiches.Include(c => c.Category);
        public IEnumerable<Sandwich> FavoriteSandwiches => _context.Sandwiches.Where(s => s.IsFavoriteSandwich).Include(c => c.Category);
        public Sandwich GetSandwichById(int sandwichId) => _context.Sandwiches.FirstOrDefault(s => s.SandwichId == sandwichId);
    }
}