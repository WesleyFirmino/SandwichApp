using SandwichApp.Models;

namespace SandwichApp.Repositories.Interfaces;
public interface ISandwichRepository
{
    IEnumerable<Sandwich> Sandwiches { get; }
    IEnumerable<Sandwich> FavoriteSandwiches {get; }
    Sandwich GetSandwichById(int sandwichId);
}