using Microsoft.EntityFrameworkCore;
using SandwichApp.Models;

namespace SandwichApp.Context;
public class SandwichContext : DbContext
{
    public SandwichContext(DbContextOptions<SandwichContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Sandwich> Sandwiches { get; set; }
    public DbSet<CarBuyItem> CarBuyItems { get; set; }
}