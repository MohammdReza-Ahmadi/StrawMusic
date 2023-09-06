using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulaition(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {

                Console.WriteLine("---> seed data 0......");

                context.Platforms.AddRange(
                    new Platform() { Name = "Dot net", Publisher = "microsoft1", Cost = "Free" },
                    new Platform() { Name = "Dot net2", Publisher = "microsoft2", Cost = "Free" },
                    new Platform() { Name = "Dot net3", Publisher = "microsoft3", Cost = "Free" }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("---> we already have data");
            }
        }
    }
}
