using SandwichApp.Models;

namespace SandwichApp.ViewModels
{
    public class SandwichListViewModel
    {
        public IEnumerable<Sandwich> Sandwiches { get; set; }
        public string CurrentCategory { get; set; }
    }
}