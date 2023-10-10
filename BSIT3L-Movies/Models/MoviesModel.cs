using System;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IMDbRating {  get; set; }
        public string Popularity { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        
    }
}

