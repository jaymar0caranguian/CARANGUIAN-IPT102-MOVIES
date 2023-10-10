using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            _movies = new List<MovieViewModel>
            {
            new MovieViewModel { Id = 1, Name = "Valerian and the City Planets of a Thousand Planets", ImagePath = "Images/valerian.jpg", IMDbRating = "6.4", Popularity = "971", ReleaseYear = 2017, Genre = "Action, Adventure, Fantasy, Sci-Fi" },
        new MovieViewModel { Id = 2, Name = "I am Mother", ImagePath = "Images/iammother.jpg", IMDbRating = "6.7", Popularity = "4,667", ReleaseYear = 2019, Genre = "Drama, Mystery, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 3, Name = "Train to Busan", ImagePath = "Images/busan.jpg", IMDbRating = "7.6", Popularity = "679", ReleaseYear = 2016, Genre = "Action, Horror,Thriller" },
        new MovieViewModel { Id = 4, Name = "The Midnight Sky", ImagePath = "Images/midnightsky.jpg", IMDbRating = "6.7", Popularity = "4,114", ReleaseYear = 2020, Genre = "Action, Drama, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 5, Name = "The Martian", ImagePath = "Images/martian.png", IMDbRating = "8.0", Popularity = "704", ReleaseYear = 2015, Genre = "Adventure, Drama, Scifi" },
        new MovieViewModel { Id = 6, Name = "2012", ImagePath = "Images/2012.jpg", IMDbRating = "5.8", Popularity = "1,236", ReleaseYear = 2009, Genre = "Action, Adventure, Sci-Fi" },
        new MovieViewModel { Id = 7, Name = "The 5th Wave", ImagePath = "Images/fifthwave.jpg", IMDbRating = "5.2", Popularity = "2,059", ReleaseYear = 2016, Genre = "Action, Adventure, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 8, Name = "The Core", ImagePath = "Images/core.jpg", IMDbRating = "5.5", Popularity = "4,163", ReleaseYear = 2003, Genre = "Action, Adventure, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 9, Name = "Mortal Engine", ImagePath = "Images/mortalengine.jpg", IMDbRating = "6.1", Popularity = "2,578", ReleaseYear = 2018, Genre = "Action, Adventure, Fantasy, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 10, Name = "Interstellar", ImagePath = "Images/interstellar.jpg", IMDbRating = "8.7", Popularity = "87", ReleaseYear = 2014, Genre = "Adventure, Drama, Sci-Fi" },
        new MovieViewModel { Id = 11, Name = "Ready Player One", ImagePath = "Images/readyplayer.jpg", IMDbRating = "7.4", Popularity = "652", ReleaseYear = 2018, Genre = "Action, Adventure, Sci-Fi" },
        new MovieViewModel { Id = 12, Name = "The Wandering Earth", ImagePath = "Images/wandering.jpg", IMDbRating = "5.9", Popularity = "3,895", ReleaseYear = 2019, Genre = "Action, Adventure, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 13, Name = "Space Sweepers", ImagePath = "Images/spacesweepers.jpg", IMDbRating = "6.5", Popularity = "", ReleaseYear = 2021, Genre = "Action, Adventure, Drama, Fantasy, Sci-Fi" },
        new MovieViewModel { Id = 14, Name = "Shanghai Fortress", ImagePath = "Images/shanghai.jpg", IMDbRating = "4.4", Popularity = "", ReleaseYear = 2019, Genre = "Action, Sci-Fi" },
        new MovieViewModel { Id = 15, Name = "The Cloverfield Paradox", ImagePath = "Images/paradox.jpg", IMDbRating = "5.5", Popularity = "2,057", ReleaseYear = 2018, Genre = "Action, Adventure, Horror" },
        new MovieViewModel { Id = 16, Name = "Dune", ImagePath = "Images/dune.jpg", IMDbRating = "8.0", Popularity = "70", ReleaseYear = 2021, Genre = "Action, Adventure, Drama, Sci-Fi" }
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", IMDbRating = "5", Popularity = "15" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

