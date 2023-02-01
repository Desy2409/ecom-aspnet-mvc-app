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
                            Logo = "https://www.designhill.com/design-blog/wp-content/uploads/2019/04/4.jpg",
                            Name = "DreamWorks",
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and " +
                            "I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness."
                        },
                        new Cinema
                        {
                            //Id = 2,
                            Logo = "https://www.designfier.com/blog/wp-content/uploads/2021/06/WARNER.jpg",
                            Name = "Warner Bros Pictures",
                            Description = "No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful."
                        },
                        new Cinema
                        {
                            //Id = 3,
                            Logo = "https://st2.depositphotos.com/3477813/47017/v/600/depositphotos_470176232-stock-illustration-pirate-films-studio-movie-video.jpg",
                            Name = "Pirate Film Studio",
                            Description = "Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure."
                        },
                        new Cinema
                        {
                            //Id = 4,
                            Logo = "https://entertainment.time.com/wp-content/uploads/sites/3/2012/09/mgm.jpg?w=720&h=480&crop=1",
                            Name = "Metro Goldwyn Mayer",
                            Description = "To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it ?"
                        },
                        new Cinema
                        {
                            //Id = 5,
                            Logo = "https://www.designfier.com/blog/wp-content/uploads/2021/06/LEGENDARY.jpg",
                            Name = "Legendary",
                            Description = "But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure ?"
                        }
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
