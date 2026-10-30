using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public async Task<IActionResult> List(string category)
        {
            string currentCategory = "All pies";
			List<Pie> pies;

			if (string.IsNullOrWhiteSpace(category))
			{
				pies = await _pieRepository.GetAllAsync();
			}
			else
			{
				currentCategory = category.Trim();
				pies = await _pieRepository.GetByCategoryAsync(currentCategory);
			}

			var viewModel = new PieListViewModel
			{
				Pies = pies,
				CurrentCategory = currentCategory
			};

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var pie = await _pieRepository.GetByIdAsync(id);

            return pie is null ? NotFound() : View(pie);
        }
    }
}
