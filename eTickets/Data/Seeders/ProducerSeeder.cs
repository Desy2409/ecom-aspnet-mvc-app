using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Seeders
{
    public class ProducerSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer
                        {
                            //Id = 1,
                            ProfilePictureURL = "https://cdn.britannica.com/04/113304-050-F9162580/Spike-Lee-2007.jpg",
                            FullName = "Spike Lee",
                            Bio = "Né à Atlanta en Géorgie3, il est le fils de Jacqueline Carroll (née Shelton), " +
                            "professeure d'arts et de littérature, et de Bill Lee, musicien et compositeur"
                        },
                        new Producer
                        {
                            //Id = 2,
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Brad_Pitt_2019_by_Glenn_Francis.jpg/1200px-Brad_Pitt_2019_by_Glenn_Francis.jpg",
                            FullName = "Prad Pitt",
                            Bio = "William Bradley Pitt, dit Brad Pitt, est un acteur et producteur de cinéma américain, " +
                            "né le 18 décembre 1963 à Shawnee. Repéré dans une publicité pour Levi's, Brad Pitt sort de l'anonymat " +
                            "grâce à un petit rôle dans le film Thelma et Louise de Ridley Scott."
                        },
                        new Producer
                        {
                            //Id = 3,
                            ProfilePictureURL = "http://travelboulder.com/wp-content/uploads/2022/02/AB2021HeadshotApproved-1024x1019-1.jpeg",
                            FullName = "Alec Baldwin",
                            Bio = "Alexander Rae Baldwin III, dit Alec Baldwin, né le 3 avril 1958 à Massapequa, est un acteur, " +
                            "réalisateur et producteur délégué de cinéma américain."
                        },
                        new Producer
                        {
                            //Id = 4,
                            ProfilePictureURL = "https://www.lucasfilm.com/app/uploads/833x523.jpg",
                            FullName = "Kathleen Kennedy",
                            Bio = "Kathleen Kennedy est une productrice de cinéma américaine, née le 5 juin 1953 à Berkeley, Californie. " +
                            "Elle est l'épouse de Frank Marshall, avec qui elle a fondé The Kennedy/Marshall Company en 1992. " +
                            "Elle est productrice associée d'un grand nombre de films de Steven Spielberg."
                        },
                        new Producer
                        {
                            //Id = 5,
                            ProfilePictureURL = "https://alumni-friends.brown.edu/sites/g/files/dprerj671/files/nina-inset.jpg",
                            FullName = "Nina Jacobson",
                            Bio = "Nina Jacobson est une productrice américaine née en 1966. Depuis 2006, elle est la présidente du Walt Disney Motion Pictures Group. " +
                            "Avec Dawn Steel, Gail Berman et Sherry Lansing, elle est l'une des dernières femmes à diriger un studio de production hollywoodien."
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
