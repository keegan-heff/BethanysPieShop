using BethanysPieShop.Models;
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
            ViewBag.CurrentCategory = "All pies";

            var pies = await _context.Pies
                .AsNoTracking()
                .OrderBy(p => p.PieId)
                .ToListAsync();

            return View(pies);
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
