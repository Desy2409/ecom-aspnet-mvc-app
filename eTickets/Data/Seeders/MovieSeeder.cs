using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data.Seeders
{
    public class MovieSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            //Id = 1,
                            Name = "Equalizer",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                            StartDate = DateTime.Now.AddDays(20),
                            EndDate = DateTime.Now.AddDays(10),
                            Price = 40,
                            ImageURL = "https://m.media-amazon.com/images/I/51Lm88Xc9GL._AC_SY580_.jpg",
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drame
                        },
                        new Movie()
                        {
                            //Id = 2,
                            Name = "Shaft",
                            Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(2),
                            Price = 55.2M,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BYmJhNWMyOTUtZjgwZS00YzdjLTk1MmMtODJlOTExMDQ3MDU5XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            //Id = 3,
                            Name = "Gemini Man",
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            Price = 200,
                            ImageURL = "https://www.crew-united.com/Media/Images/976/976356/976356.entity.jpg",
                            CinemaId = 2,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Fiction
                        },
                        new Movie()
                        {
                            //Id = 4,
                            Name = "The Magic Of Belle Isle",
                            Description = "Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. " +
                            "Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem.",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now,
                            Price = 30.5M,
                            ImageURL = "http://www.magpictures.com/themagicofbelleisle/images/photos/photo_11.jpg",
                            CinemaId = 5,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Famille
                        },
                        new Movie()
                        {
                            //Id = 5,
                            Name = "Jurasic World",
                            Description = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? " +
                            "Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?",
                            StartDate = DateTime.Now.AddDays(-7),
                            EndDate = DateTime.Now.AddDays(-3),
                            Price = 75,
                            ImageURL = "https://fr.web.img2.acsta.net/pictures/22/04/14/18/30/0040092.jpg",
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
