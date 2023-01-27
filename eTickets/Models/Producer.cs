namespace eTickets.Models
{
    public class Producer : Person
    {

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
