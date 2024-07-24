using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SandwichApp.Models;
public class Category
{
    public Category()
    {
        Sandwiches = new Collection<Sandwich>();
    }

    [Key]
    public int CategoryId { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [Required]
    [StringLength(200)]
    public string Description { get; set; }
    public ICollection<Sandwich> Sandwiches { get; set; }
}