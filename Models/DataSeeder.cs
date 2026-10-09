namespace BethanysPieShop.Models
{
    public static class DataSeeder
    {
        public static void Initialize(IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var ctx = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            ctx.Database.EnsureCreated();

            if (!ctx.Pies.Any())
            {
                ctx.Pies.AddRange(StaticPieData.GetAll());
                ctx.SaveChanges();
            }
        }
    }
}
