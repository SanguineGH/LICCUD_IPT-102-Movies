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
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Trailer = "/Trailers/Titanic.mp4"},
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Trailer = "/Trailers/Inception.mp4" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Trailer = "/Trailers/Shawshank.mp4" },
			new MovieViewModel { Id = 4, Name = "Deepwater Horizon", Rating = "5", ReleaseYear = 2016, Genre = "Drama", Trailer = "/Trailers/Deepwater Horizon.mp4" },
new MovieViewModel { Id = 5, Name = "Rampage", Rating = "5", ReleaseYear = 2018, Genre = "Action", Trailer = "/Trailers/Rampage.mp4" },
new MovieViewModel { Id = 6, Name = "Heneral Luna", Rating = "5", ReleaseYear = 2015, Genre = "Biography", Trailer = "/Trailers/Heneral Luna.mp4" },
new MovieViewModel { Id = 7, Name = "The Tomorrow War", Rating = "5", ReleaseYear = 2021, Genre = "Drama", Trailer = "/Trailers/The Tomorrow War.mp4" },
new MovieViewModel { Id = 8, Name = "Ready Player One", Rating = "5", ReleaseYear = 2018, Genre = "Sci-Fi", Trailer = "/Trailers/Ready P1.mp4" },
new MovieViewModel { Id = 9, Name = "Battleship", Rating = "5", ReleaseYear = 2012, Genre = "Sci-Fi", Trailer = "/Trailers/Battleship.mp4" },
new MovieViewModel { Id = 10, Name = "I Am Legend", Rating = "5", ReleaseYear = 2007, Genre = "Horror", Trailer = "/Trailers/Legend.mp4" },
new MovieViewModel { Id = 11, Name = "Man of Steel", Rating = "5", ReleaseYear = 2013, Genre = "Adventure", Trailer = "/Trailers/Superman.mp4" },
new MovieViewModel { Id = 12, Name = "Interstellar", Rating = "5", ReleaseYear = 2014, Genre = "Sci-Fi", Trailer = "/Trailers/Interstellar.mp4" },
new MovieViewModel { Id = 13, Name = "Tenet", Rating = "5", ReleaseYear = 2020, Genre = "Thriller", Trailer = "/Trailers/Tenet.mp4" },
new MovieViewModel { Id = 14, Name = "Dunkirk", Rating = "5", ReleaseYear = 2017, Genre = "History", Trailer = "/Trailers/Dunkirk.mp4" },
new MovieViewModel { Id = 15, Name = "The Prestige", Rating = "5", ReleaseYear = 2006, Genre = "Mystery", Trailer = "/Trailers/Prestige.mp4" },
			};
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
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

