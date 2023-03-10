using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name="Description")]
        public string Description { get; set; }
        [Display(Name="Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name="End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name="Price")]
        public decimal Price { get; set; }
        [Display(Name="Movie Image")]
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        // public int CinemaId { get; set; } == [ForeignKey("CinemaId")]
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        // public int ProducerId { get; set; } == [ForeignKey("ProducerId")]
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
        public int CinemaId { get; internal set; }
        public int ProducerId { get; internal set; }
    }
}
