using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Models
{
	public class Contact
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string? Subject { get; set; }
		public string Message { get; set; } = string.Empty;
	}
}
