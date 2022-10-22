using Microsoft.IdentityModel.Tokens;

namespace Platform.API.Data
{
    public static class PrepDb
    {
        public static void prepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding data....");

                context.Platforms.AddRange(
                    new Models.Platform() { Name="Dot Net", Publisher="Microsoft", Cost="Free"},
                    new Models.Platform() { Name="Sql server Express", Publisher="Microsoft", Cost="Free"},
                    new Models.Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                    );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We have already data.");
            }
        }
    }
}
