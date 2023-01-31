namespace eTickets.Data.Seeders
{
    public class DatabaseSeeder
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //var seeders = new List<string> { "ActorSeeder", "ProducerSeeder", "CinemaSeeder" };
            //foreach (var seeder in seeders)
            //{
            //    seeder.Seed(applicationBuilder);
            //}

            //Actors seeder.
            ActorSeeder.Seed(applicationBuilder);
            //Producers seeder.
            ProducerSeeder.Seed(applicationBuilder);
            //Cinemas seeder.
            CinemaSeeder.Seed(applicationBuilder);


        }

    }
}
