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
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
			new MovieViewModel { Id = 4, Name = "Deepwater Horizon", Rating = "5", ReleaseYear = 2016, Genre = "Drama" },
new MovieViewModel { Id = 5, Name = "Rampage", Rating = "5", ReleaseYear = 2018, Genre = "Action" },
new MovieViewModel { Id = 6, Name = "Heneral Luna", Rating = "5", ReleaseYear = 2015, Genre = "Biography" },
new MovieViewModel { Id = 7, Name = "The Tomorrow War", Rating = "5", ReleaseYear = 2021, Genre = "Drama" },
new MovieViewModel { Id = 8, Name = "Ready Player One", Rating = "5", ReleaseYear = 2018, Genre = "Sci-Fi" },
new MovieViewModel { Id = 9, Name = "Battleship", Rating = "5", ReleaseYear = 2012, Genre = "Sci-Fi" },
new MovieViewModel { Id = 10, Name = "I Am Legend", Rating = "5", ReleaseYear = 2007, Genre = "Horror" },
new MovieViewModel { Id = 11, Name = "Man of Steel", Rating = "5", ReleaseYear = 2013, Genre = "Adventure" },
new MovieViewModel { Id = 12, Name = "Interstellar", Rating = "5", ReleaseYear = 2014, Genre = "Sci-Fi" },
new MovieViewModel { Id = 13, Name = "Tenet", Rating = "5", ReleaseYear = 2020, Genre = "Thriller" },
new MovieViewModel { Id = 14, Name = "Dunkirk", Rating = "5", ReleaseYear = 2017, Genre = "History" },
new MovieViewModel { Id = 15, Name = "The Prestige", Rating = "5", ReleaseYear = 2006, Genre = "Mystery" },
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

