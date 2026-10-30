using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BethanysPieShop.Migrations
{
    /// <inheritdoc />
    public partial class DataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fruit pies", null },
                    { 2, "Cheese cakes", null },
                    { 3, "Seasonal pies", null }
                });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/caramelpopcorncheesecake.jpg", true, true, "A rich, velvety cheesecake layered with golden caramel and finished with a generous topping of caramel popcorn for the perfect balance of smooth and crunchy.", "Caramel Popcorn Cheese Cake", 22.95m, "Silky cheesecake topped with caramel popcorn crunch." },
                    { 2, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/chocolatecheesecake.jpg", true, true, "Smooth dark chocolate cheesecake baked on a crunchy cookie crust and finished with chocolate curls. Rich, indulgent, and absolutely irresistible.", "Chocolate Cheese Cake", 19.95m, "Chocolate lover’s dream on a cookie crust." },
                    { 3, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/pistachecheesecake.jpg", true, true, "An elegant pistachio-infused cheesecake with a nutty aroma and a hint of vanilla, topped with crushed roasted pistachios for extra flavor and texture.", "Pistache Cheese Cake", 21.95m, "Creamy cheesecake with roasted pistachios." },
                    { 4, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/fruitpies/pecanpie.jpg", true, false, "A buttery, flaky crust filled with toasted pecans and a sweet caramelized filling. Crispy on top, gooey inside, and pure comfort with every slice.", "Pecan Pie", 21.95m, "Classic southern pie loaded with pecans." },
                    { 5, null, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/seasonal/birthdaypie.jpg", true, false, "Layers of vanilla custard and colorful sprinkles baked in a sweet pastry shell, topped with whipped cream — a perfect centerpiece for birthdays or any celebration.", "Birthday Pie", 29.95m, "Celebrate any day with sprinkles and joy." },
                    { 6, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, false, "Freshly sliced apples tossed in cinnamon sugar, baked in a golden flaky crust. A timeless favorite that tastes like home.", "Apple Pie", 12.95m, "Our bakery’s famous warm apple pie." },
                    { 7, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/blueberrycheesecake.jpg", true, false, "A smooth cheesecake base layered with a sweet blueberry compote. A balance of tangy and sweet that’s as beautiful as it is delicious.", "Blueberry Cheese Cake", 18.95m, "Creamy cheesecake topped with wild blueberries." },
                    { 8, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/bethanyspieshop/cheesecakes/cheesecake.jpg", true, false, "Rich, creamy, and timeless — our original cheesecake lets the smooth texture and subtle vanilla flavor shine through. Sometimes simple really is best.", "Cheese Cake", 18.95m, "Classic plain cheesecake, simple and pure." },
                    { 9, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, false, "A juicy filling of ripe cherries wrapped in flaky pastry and baked until bubbling. Sweet, tangy, and the perfect balance of fruit and crust.", "Cherry Pie", 15.95m, "Sweet and tart cherries in a golden crust." },
                    { 10, null, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, false, "Apples baked with cinnamon, nutmeg, and cloves inside a buttery crust. A warm, cozy pie that smells like Christmas morning.", "Christmas Apple Pie", 13.95m, "Holiday spices meet our classic apple filling." },
                    { 11, null, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, false, "Bright red cranberries cooked down with sugar and citrus, baked in a flaky shell for a tart and festive flavor that’s perfect for winter.", "Cranberry Pie", 17.95m, "Tangy cranberries with a hint of orange zest." },
                    { 12, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, false, "Juicy, golden peaches nestled in a buttery crust and baked until tender and fragrant — a slice of summer all year long.", "Peach Pie", 15.95m, "Sun-ripened peaches baked to perfection." },
                    { 13, null, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, false, "Smooth pumpkin custard seasoned with cinnamon, nutmeg, and ginger, baked in a buttery crust. The ultimate autumn dessert.", "Pumpkin Pie", 12.95m, "A seasonal classic with warm spices." },
                    { 14, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, false, "Our rhubarb pie delivers that perfect tangy kick, balanced with just enough sweetness for a refreshingly bright dessert.", "Rhubarb Pie", 15.95m, "Sweet-tart rhubarb in a flaky homemade crust." },
                    { 15, null, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, false, "Bright strawberries layered in a buttery crust and covered in a light glaze. Simple, fresh, and bursting with natural flavor.", "Strawberry Pie", 15.95m, "Fresh strawberries, sweet glaze, perfect crust." },
                    { 16, null, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, false, "A smooth vanilla cheesecake topped with glossy strawberry sauce and slices of fresh fruit. Sweet, creamy, and absolutely delightful.", "Strawberry Cheese Cake", 18.95m, "Classic cheesecake with fresh strawberry topping." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
