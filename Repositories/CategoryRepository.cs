using SandwichApp.Context;
using SandwichApp.Models;
using SandwichApp.Repositories.Interfaces;

namespace SandwichApp.Repositories;
public class CategoryRepository : ICategoryRepository
{
    private readonly SandwichContext _context;

    public CategoryRepository(SandwichContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> Categories => _context.Categories;
}