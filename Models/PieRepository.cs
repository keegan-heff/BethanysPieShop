using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
	public class PieRepository : IPieRepository
	{
		private readonly AppDbContext _appDbContext;

		public PieRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<List<Pie>> GetAllAsync()
		{
			return await _appDbContext.Pies.AsNoTracking()
				.Include(p => p.Category)
				.OrderBy(p => p.PieId)
				.ToListAsync();
		}

		public async Task<Pie?> GetByIdAsync(int id)
		{
			return await _appDbContext.Pies.AsNoTracking()
				.Include(p => p.Category)
				.FirstOrDefaultAsync(p => p.PieId == id);
		}

		public async Task<List<Pie>> GetByCategoryAsync(string categoryName)
		{
			var lower = categoryName.Trim().ToLower();

			return await _appDbContext.Pies.AsNoTracking()
				.Include(p => p.Category)
				.Where(p => p.Category != null && p.Category.CategoryName.ToLower() == lower)
				.ToListAsync();
		}
	}
}
