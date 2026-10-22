namespace BethanysPieShop.Models
{
    public static class StaticPieData
    {
        private static readonly List<Pie> _pies = new()
    {
        new Pie
        {
            PieId = 1,
            Name = "Caramel Popcorn Cheese Cake",
            Price = 22.95M,
            ShortDescription = "The ultimate cheese cake",
            LongDescription = "Ultra-creamy cheesecake on a crisp biscuit base, finished with a glossy caramel sauce and a crown of crunchy caramel popcorn. Every bite balances buttery sweetness with a gentle tang from the cream cheese. It’s playful, showy, and unapologetically indulgent—the dessert you bring when you want all eyes on the table.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecake.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecakesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = true,
            AllergyInformation = ""
        },
        new Pie
        {
            PieId = 2,
            Name = "Chocolate Cheese Cake",
            Price = 19.95M,
            ShortDescription = "The chocolate lover's dream",
            LongDescription = "Silky dark-chocolate cheesecake baked low and slow for that perfect velvet texture, set on a cocoa-butter biscuit crust. A soft ganache blanket on top adds a luxurious finish while keeping the sweetness balanced. Deep, rich, and elegant—this is chocolate doing grown-up dessert.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecake.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecakesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = true,
            AllergyInformation = ""
        },
        new Pie
        {
            PieId = 3,
            Name = "Pistache Cheese Cake",
            Price = 21.95M,
            ShortDescription = "We're going nuts over this one",
            LongDescription = "A pistachio-infused cheesecake with a naturally nutty aroma and a whisper of vanilla. Roasted pistachios add crunch against the smooth filling, while a golden biscuit crust brings gentle caramel notes. It’s refined and fragrant—the kind of dessert that disappears quietly and completely.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecake.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecakesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = true,
            AllergyInformation = ""
        },
        new Pie
        {
            PieId = 4,
            Name = "Pecan Pie",
            Price = 21.95M,
            ShortDescription = "More pecan than you can handle!",
            LongDescription = "Toasted pecans packed into a glossy caramel custard, all nestled in a flaky, buttery crust. The filling sets just soft enough to slice cleanly while staying fudgy at the center. It’s nutty, caramel-forward, and wonderfully old-fashioned—in the best possible way.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpie.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpiesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = false,
            AllergyInformation = ""
        },
        new Pie
        {
            PieId = 5,
            Name = "Apple Pie",
            Price = 12.95M,
            ShortDescription = "Our famous apple pies!",
            LongDescription = "A classic done right: tender apples layered with cinnamon and brown sugar, baked under a golden top. The fruit keeps a little bite, the juices thicken into a cozy syrup, and the crust flakes at the touch of a fork. Warm it slightly and add a spoon of cream—perfection.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = false,
            AllergyInformation = ""
        },
        new Pie
        {
            PieId = 6,
            Name = "Blueberry Cheese Cake",
            Price = 18.95M,
            ShortDescription = "You'll love it!",
            LongDescription = "Creamy vanilla cheesecake marbled with a bright blueberry compote for bursts of fresh, jammy fruit. The biscuit base adds gentle crunch while the top stays smooth and glossy. Light, fruity, and beautifully balanced—it’s the cheesecake for when you want something sunny.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecake.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecakesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = false,
            AllergyInformation = ""
        },
        new Pie
        {
            PieId = 7,
            Name = "Cheese Cake",
            Price = 18.95M,
            ShortDescription = "Plain cheese cake. Plain pleasure.",
            LongDescription = "Our purest take: a smooth, classic cheesecake with a clean cream-cheese profile, gentle sweetness, and a crisp buttery crust. No toppings, no distractions—just perfect texture and a quietly luxurious finish. Simplicity this good never needs dressing up.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = false,
            AllergyInformation = ""
        },
        new Pie
        {
            PieId = 8,
            Name = "Cherry Pie",
            Price = 15.95M,
            ShortDescription = "A summer classic!",
            LongDescription = "Tart cherries tumble under a latticed golden crust, bubbling into a ruby filling that sets just as the pie cools. Each slice lands that sweet-tart hit cherry pies are famous for, with buttery pastry to match. Serve it slightly warm for peak nostalgia.",
            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
            InStock = true,
            IsPieOfTheWeek = false,
            AllergyInformation = ""
        }
    };

        public static IEnumerable<Pie> GetAll() => _pies.OrderBy(p => p.PieId);
        public static Pie? GetById(int id) => _pies.FirstOrDefault(p => p.PieId == id);
    }
}
