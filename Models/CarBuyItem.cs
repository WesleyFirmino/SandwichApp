using System.ComponentModel.DataAnnotations;

namespace SandwichApp.Models;

public class CarBuyItem
{
    public int CarBuyItemId { get; set; }
    public Sandwich Sandwich { get; set; }
    public int Quantity { get; set; }
    
    [StringLength(200)]
    public string CarBuyId { get; set; }
}