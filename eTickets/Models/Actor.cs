namespace eTickets.Models
{
    public class Actor : Person
    {
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
