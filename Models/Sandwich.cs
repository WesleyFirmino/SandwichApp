using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SandwichApp.Models;
public class Sandwich
{
    [Key]
    public int SandwichId { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [Required]
    [StringLength(200)]
    public string ShortDescription { get; set; }

    [Required]
    [StringLength(200)]
    public string CompleteDescription { get; set; }

    [Required]
    [Column(TypeName = "decimal(10, 2)")]
    [Range(1, 999.99)]
    public decimal Price { get; set; }
    
    [StringLength(200)]
    public string ImageURL { get; set; }
    
    [StringLength(200)]
    public string ImagemThumbnailURL { get; set; }
    public bool IsFavoriteSandwich { get; set; }
    public bool InStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}