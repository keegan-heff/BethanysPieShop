namespace BethanysPieShop.Models
{
	public static class StaticContactData
	{
		private static readonly List<Contact> _items = new();
		private static int _nextId = 1;

		public static void Add(Contact item)
		{
			item.Id = _nextId++;
			_items.Add(item);
		}

		public static IReadOnlyList<Contact> All()
		{
			return _items.ToList();
		}
	}
}
