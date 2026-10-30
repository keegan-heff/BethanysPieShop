using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Pie> Pies { get; set;}
		public DbSet<Category> Categories { get; set;}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().HasData(
				new Category { CategoryId = 1, CategoryName = "Fruit pies" },
				new Category { CategoryId = 2, CategoryName = "Cheese cakes" },
				new Category { CategoryId = 3, CategoryName = "Seasonal pies" }
			);

			modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    PieId = 1,
                    Name = "Caramel Popcorn Cheese Cake",
                    Price = 22.95M,
                    ShortDescription = "Silky cheesecake topped with caramel popcorn crunch.",
                    LongDescription = "A rich, velvety cheesecake layered with golden caramel and finished with a generous topping of caramel popcorn for the perfect balance of smooth and crunchy.",
                    CategoryId = 2,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecake.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecakesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true
                },
                new Pie
                {
                    PieId = 2,
                    Name = "Chocolate Cheese Cake",
                    Price = 19.95M,
                    ShortDescription = "Chocolate lover’s dream on a cookie crust.",
                    LongDescription = "Smooth dark chocolate cheesecake baked on a crunchy cookie crust and finished with chocolate curls. Rich, indulgent, and absolutely irresistible.",
                    CategoryId = 2,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecake.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecakesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true
                },
                new Pie
                {
                    PieId = 3,
                    Name = "Pistache Cheese Cake",
                    Price = 21.95M,
                    ShortDescription = "Creamy cheesecake with roasted pistachios.",
                    LongDescription = "An elegant pistachio-infused cheesecake with a nutty aroma and a hint of vanilla, topped with crushed roasted pistachios for extra flavor and texture.",
                    CategoryId = 2,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecake.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecakesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true
                },
                new Pie
                {
                    PieId = 4,
                    Name = "Pecan Pie",
                    Price = 21.95M,
                    ShortDescription = "Classic southern pie loaded with pecans.",
                    LongDescription = "A buttery, flaky crust filled with toasted pecans and a sweet caramelized filling. Crispy on top, gooey inside, and pure comfort with every slice.",
                    CategoryId = 1,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 5,
                    Name = "Birthday Pie",
                    Price = 29.95M,
                    ShortDescription = "Celebrate any day with sprinkles and joy.",
                    LongDescription = "Layers of vanilla custard and colorful sprinkles baked in a sweet pastry shell, topped with whipped cream — a perfect centerpiece for birthdays or any celebration.",
                    CategoryId = 3,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 6,
                    Name = "Apple Pie",
                    Price = 12.95M,
                    ShortDescription = "Our bakery’s famous warm apple pie.",
                    LongDescription = "Freshly sliced apples tossed in cinnamon sugar, baked in a golden flaky crust. A timeless favorite that tastes like home.",
                    CategoryId = 1,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 7,
                    Name = "Blueberry Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "Creamy cheesecake topped with wild blueberries.",
                    LongDescription = "A smooth cheesecake base layered with a sweet blueberry compote. A balance of tangy and sweet that’s as beautiful as it is delicious.",
                    CategoryId = 2,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecake.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecakesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 8,
                    Name = "Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "Classic plain cheesecake, simple and pure.",
                    LongDescription = "Rich, creamy, and timeless — our original cheesecake lets the smooth texture and subtle vanilla flavor shine through. Sometimes simple really is best.",
                    CategoryId = 2,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 9,
                    Name = "Cherry Pie",
                    Price = 15.95M,
                    ShortDescription = "Sweet and tart cherries in a golden crust.",
                    LongDescription = "A juicy filling of ripe cherries wrapped in flaky pastry and baked until bubbling. Sweet, tangy, and the perfect balance of fruit and crust.",
                    CategoryId = 1,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 10,
                    Name = "Christmas Apple Pie",
                    Price = 13.95M,
                    ShortDescription = "Holiday spices meet our classic apple filling.",
                    LongDescription = "Apples baked with cinnamon, nutmeg, and cloves inside a buttery crust. A warm, cozy pie that smells like Christmas morning.",
                    CategoryId = 3,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 11,
                    Name = "Cranberry Pie",
                    Price = 17.95M,
                    ShortDescription = "Tangy cranberries with a hint of orange zest.",
                    LongDescription = "Bright red cranberries cooked down with sugar and citrus, baked in a flaky shell for a tart and festive flavor that’s perfect for winter.",
                    CategoryId = 3,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 12,
                    Name = "Peach Pie",
                    Price = 15.95M,
                    ShortDescription = "Sun-ripened peaches baked to perfection.",
                    LongDescription = "Juicy, golden peaches nestled in a buttery crust and baked until tender and fragrant — a slice of summer all year long.",
                    CategoryId = 1,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 13,
                    Name = "Pumpkin Pie",
                    Price = 12.95M,
                    ShortDescription = "A seasonal classic with warm spices.",
                    LongDescription = "Smooth pumpkin custard seasoned with cinnamon, nutmeg, and ginger, baked in a buttery crust. The ultimate autumn dessert.",
                    CategoryId = 3,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 14,
                    Name = "Rhubarb Pie",
                    Price = 15.95M,
                    ShortDescription = "Sweet-tart rhubarb in a flaky homemade crust.",
                    LongDescription = "Our rhubarb pie delivers that perfect tangy kick, balanced with just enough sweetness for a refreshingly bright dessert.",
                    CategoryId = 1,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 15,
                    Name = "Strawberry Pie",
                    Price = 15.95M,
                    ShortDescription = "Fresh strawberries, sweet glaze, perfect crust.",
                    LongDescription = "Bright strawberries layered in a buttery crust and covered in a light glaze. Simple, fresh, and bursting with natural flavor.",
                    CategoryId = 1,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false
                },
                new Pie
                {
                    PieId = 16,
                    Name = "Strawberry Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "Classic cheesecake with fresh strawberry topping.",
                    LongDescription = "A smooth vanilla cheesecake topped with glossy strawberry sauce and slices of fresh fruit. Sweet, creamy, and absolutely delightful.",
                    CategoryId = 2,
                    ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                    ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false
                }
            );
		}
    }
}
