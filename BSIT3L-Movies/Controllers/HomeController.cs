using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
        new MovieViewModel { Id = 1, Name = "Valerian and the City Planets of a Thousand Planets", IMDbRating = "6.4", Popularity = "971", ReleaseYear = 2017, Genre = "Action, Adventure, Fantasy, Sci-Fi" },
        new MovieViewModel { Id = 2, Name = "I am Mother", IMDbRating = "6.7", Popularity = "4,667", ReleaseYear = 2019, Genre = "Drama, Mystery, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 3, Name = "Train to Busan", IMDbRating = "7.6", Popularity = "679", ReleaseYear = 2016, Genre = "Action, Horror,Thriller" },
        new MovieViewModel { Id = 4, Name = "The Midnight Sky", IMDbRating = "6.7", Popularity = "4,114", ReleaseYear = 2020, Genre = "Action, Drama, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 5, Name = "The Martian", IMDbRating = "8.0", Popularity = "704", ReleaseYear = 2015, Genre = "Adventure, Drama, Scifi" },
        new MovieViewModel { Id = 6, Name = "2012", IMDbRating = "5.8", Popularity = "1,236", ReleaseYear = 2009, Genre = "Action, Adventure, Sci-Fi" },
        new MovieViewModel { Id = 7, Name = "The 5th Wave", IMDbRating = "5.2", Popularity = "2,059", ReleaseYear = 2016, Genre = "Action, Adventure, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 8, Name = "The Core", IMDbRating = "5.5", Popularity = "4,163", ReleaseYear = 2003, Genre = "Action, Adventure, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 9, Name = "Mortal Engine", IMDbRating = "6.1", Popularity = "2,578", ReleaseYear = 2018, Genre = "Action, Adventure, Fantasy, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 10, Name = "Interstellar", IMDbRating = "8.7", Popularity = "87", ReleaseYear = 2014, Genre = "Adventure, Drama, Sci-Fi" },
        new MovieViewModel { Id = 11, Name = "Ready Player One", IMDbRating = "7.4", Popularity = "652", ReleaseYear = 2018, Genre = "Action, Adventure, Sci-Fi" },
        new MovieViewModel { Id = 12, Name = "The Wandering Earth", IMDbRating = "5.9", Popularity = "3,895", ReleaseYear = 2019, Genre = "Action, Adventure, Sci-Fi, Thriller" },
        new MovieViewModel { Id = 13, Name = "Space Sweepers", IMDbRating = "6.5", Popularity = "", ReleaseYear = 2021, Genre = "Action, Adventure, Drama, Fantasy, Sci-Fi" },
        new MovieViewModel { Id = 14, Name = "Shanghai Fortress", IMDbRating = "4.4", Popularity = "", ReleaseYear = 2019, Genre = "Action, Sci-Fi" },
        new MovieViewModel { Id = 15, Name = "The Cloverfield Paradox", IMDbRating = "5.5", Popularity = "2,057", ReleaseYear = 2018, Genre = "Action, Adventure, Horror" }
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

