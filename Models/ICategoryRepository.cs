namespace BethanysPieShop.Models
{
	public interface ICategoryRepository
	{
		Task<List<Category>> GetAllAsync();
	}
}
