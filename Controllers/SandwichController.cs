using Microsoft.AspNetCore.Mvc;
using SandwichApp.Repositories.Interfaces;

namespace SandwichApp.Controllers
{
    public class SandwichController : Controller
    {
        private readonly ISandwichRepository _sandwichRepository;

        public SandwichController(ISandwichRepository sandwichRepository)
        {
            _sandwichRepository = sandwichRepository;
        }

        public IActionResult SandwichList()
        {
            var sandwich = _sandwichRepository.Sandwiches;
            return View(sandwich);
        }
    }
}