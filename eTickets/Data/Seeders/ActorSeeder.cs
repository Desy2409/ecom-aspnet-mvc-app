using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Seeders
{
    public class ActorSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor
                        {
                            //Id = 1,
                            ProfilePictureURL = "https://kmesh.io/img/biography/1C/denzel-washington-1.jpg",
                            FullName = "Denzel Washington",
                            Bio = "Denzel Hayes Washington Jr.2 est le fils d'un pasteur protestant, Denzel Washington Sr., originaire du comté de Buckingham (Virginie). " +
                            "Lennis « Lynne » sa mère, esthéticienne et propriétaire d'un salon de beauté3, est née en Géorgie et a passé son enfance à Harlem."
                        },
                        new Actor
                        {
                            //Id = 2,
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoVV2UQQBjh058HmWraMz8jPiTA-Vdz91cmcEXDrMThTEUvXfJulBWDXNVMkQIKsN7-R8&usqp=CAU",
                            FullName = "Samuel L. Jackson",
                            Bio = "Samuel Leroy Jackson entre au Morehouse College d'Atlanta pour entreprendre des études de policier qui furent très vite interrompues. " +
                            "Il continua en hôtellerie restauration, son rêve était d’avoir un complexe de chambres d’hôtes, des horizons de champs de vignes, " +
                            "des chevaux sur des terres, bref un grand patron chef et patron chez lui 3, mais c'est avec un diplôme d'art dramatique qu'il en ressort en 1972."
                        },
                        new Actor
                        {
                            //Id = 3,
                            ProfilePictureURL = "https://fr.web.img4.acsta.net/r_1280_720/pictures/17/02/08/16/50/452749.jpg",
                            FullName = "Will smith",
                            Bio = "Willard Carroll Smith, Jr.8 naît à Philadelphie. Sa mère Caroline (née Bright) travaille dans une école et son père Willard Carroll Smith Sr. est technicien. " +
                            "Il reçoit une éducation baptiste9. Ses parents se séparent quand il a treize ans9,10. Il a une sœur, plus âgée de quatre ans, " +
                            "Pamela, ainsi qu'une sœur et un frère (jumeaux), de trois ans plus jeunes que lui, Ellen et Harry"
                        },
                        new Actor
                        {
                            //Id = 4,
                            ProfilePictureURL = "https://cdn.britannica.com/40/144440-050-DA828627/Morgan-Freeman.jpg",
                            FullName = "Morgan Freeman",
                            Bio = "Morgan Freeman naît dans une fratrie de quatre enfants à Memphis, dans le Tennessee, de Mayme Edna Revere (1912-2000) et Morgan " +
                            "Porterfield Freeman (1915-1961), " + "ancien combattant de la Seconde Guerre mondiale2, mort d'une cirrhose du foie à 46 ans3."
                        },
                        new Actor
                        {
                            //Id = 5,
                            ProfilePictureURL = "https://resize-lejdd.lanmedia.fr/var/jdd/public/media/image/2022/07/21/10/chris-pratt-l-homme-qui-murmurait-a-l-oreille-des-dinosaures.jpg?VersionId=CIiSQtmxcy4H8C9TR5Cz70i9iI7G6adQ",
                            FullName = "Chris Pratt",
                            Bio = "Chris Pratt naît en juin 1979, à Virginia dans le Minnesota. " + "Il est l’enfant de Kathleen Louise (née Indahl), qui travaillait dans un des supermarchés Safeway, " +
                            "et de Daniel Clifton « Dan » Pratt, décédé en 2014, qui a travaillé dans les mines puis dans les rénovations de maisons3,4,5. " +
                            "Chris Pratt a également un frère. " +"Sa mère est d'ascendance norvégienne tandis que son père a des ancêtres anglais, allemands, suisses et canadiens français6,7"
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
