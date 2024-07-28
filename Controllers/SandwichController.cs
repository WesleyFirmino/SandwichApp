using Microsoft.AspNetCore.Mvc;
using SandwichApp.Repositories.Interfaces;
using SandwichApp.ViewModels;

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
            //var sandwich = _sandwichRepository.Sandwiches;
            //return View(sandwich);
            var sandwichListViewModel = new SandwichListViewModel();
            sandwichListViewModel.Sandwiches = _sandwichRepository.Sandwiches;
            sandwichListViewModel.CurrentCategory = "Current Category";

            return View(sandwichListViewModel);
        }
    }
}