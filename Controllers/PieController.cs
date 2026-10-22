using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly AppDbContext _context;

        public PieController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> List()
        {
            var pies = await _context.Pies
                .AsNoTracking()
                .OrderBy(p => p.PieId)
                .ToListAsync();

			string category = "All pies";

			var viewModel = new PieListViewModel
			{
				Pies = pies,
				CurrentCategory = category
			};

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var pie = await _context.Pies
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.PieId == id);

            return pie is null ? NotFound() : View(pie);
        }
    }
}
