using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
	public class PieListViewModel
	{
		public IEnumerable<Pie> Pies { get; set; } = Enumerable.Empty<Pie>();
		public string? CurrentCategory { get; set;}
	}
}
