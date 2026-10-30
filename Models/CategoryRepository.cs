using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly AppDbContext _appDbContext;

		public CategoryRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<List<Category>> GetAllAsync()
		{
			return await _appDbContext.Categories.AsNoTracking()
				.OrderBy(c => c.CategoryId)
				.ToListAsync();
		}
	}
}
