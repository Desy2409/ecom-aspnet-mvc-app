using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Seeders
{
    public class CinemaSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema
                        {
                            //Id = 1,
                            Logo = "https://m.media-amazon.com/images/I/51Lm88Xc9GL._AC_SY580_.jpg",
                            Name = "Equalizer",
                            Description = ""
                        },
                        new Cinema
                        {
                            //Id = 2,
                            Logo = "https://m.media-amazon.com/images/M/MV5BYmJhNWMyOTUtZjgwZS00YzdjLTk1MmMtODJlOTExMDQ3MDU5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                            Name = "Shaft",
                            Description = ""
                        },
                        new Cinema
                        {
                            //Id = 3,
                            Logo = "https://www.crew-united.com/Media/Images/976/976356/976356.entity.jpg",
                            Name = "Gemini Man",
                            Description = ""
                        },
                        new Cinema
                        {
                            //Id = 3,
                            Logo = "http://www.magpictures.com/themagicofbelleisle/images/photos/photo_11.jpg",
                            Name = "The Magic Of Belle Isle",
                            Description = ""
                        },
                        new Cinema
                        {
                            //Id = 3,
                            Logo = "https://fr.web.img2.acsta.net/pictures/22/04/14/18/30/0040092.jpg",
                            Name = "Jurassic World",
                            Description = ""
                        }
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
