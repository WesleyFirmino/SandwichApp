using SandwichApp.Models;

namespace SandwichApp.Repositories.Interfaces;
public interface ICategoryRepository
{
    IEnumerable<Category> Categories{ get; }
}