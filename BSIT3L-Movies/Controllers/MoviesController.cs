﻿using System;
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
			new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Trailer = "/Trailers/Titanic.mp4", Desc= "James Cameron's \"Titanic\" is an epic, action-packed romance set against the ill-fated maiden voyage of the R.M.S. Titanic; the pride and joy of the White Star Line and, at the time, the largest moving object ever built. She was the most luxurious liner of her era -- the \"ship of dreams\" -- which ultimately carried over 1,500 people to their death in the ice cold waters of the North Atlantic in the early hours of April 15, 1912.", Poster="/Images/Titanic.jpg"},
			new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Trailer = "/Trailers/Inception.mp4", Desc= "Dom Cobb (Leonardo DiCaprio) is a thief with the rare ability to enter people's dreams and steal their secrets from their subconscious. His skill has made him a hot commodity in the world of corporate espionage but has also cost him everything he loves. Cobb gets a chance at redemption when he is offered a seemingly impossible task: Plant an idea in someone's mind. If he succeeds, it will be the perfect crime, but a dangerous enemy anticipates Cobb's every move." , Poster="/Images/Inception.jpg"},
			new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Trailer = "/Trailers/Shawshank.mp4", Desc= "Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison. However, only Andy knows he didn't commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years.", Poster="/Images/Shawn.jpg" },
			new MovieViewModel { Id = 4, Name = "Deepwater Horizon", Rating = "5", ReleaseYear = 2016, Genre = "Drama", Trailer = "/Trailers/Deepwater Horizon.mp4", Desc= "On April 20, 2010, the Deepwater Horizon drilling rig explodes in the Gulf of Mexico, igniting a massive fireball that kills several crew members. Chief electronics technician Mike Williams (Mark Wahlberg) and his colleagues find themselves fighting for survival as the heat and the flames become stifling and overwhelming. Banding together, the co-workers must use their wits to make it out alive amid all the chaos." , Poster = "/Images/Deep.jpg"},
			new MovieViewModel { Id = 5, Name = "Rampage", Rating = "5", ReleaseYear = 2018, Genre = "Action", Trailer = "/Trailers/Rampage.mp4", Desc= "Primatologist Davis Okoye shares an unshakable bond with George, an extraordinarily intelligent, silverback gorilla that's been in his care since birth. When a rogue genetic experiment goes wrong, it causes George, a wolf and a reptile to grow to a monstrous size. As the mutated beasts embark on a path of destruction, Okoye teams up with a discredited genetic engineer and the military to secure an antidote and prevent a global catastrophe." , Poster = "/Images/Rampage.jpg"},
			new MovieViewModel { Id = 6, Name = "Heneral Luna", Rating = "5", ReleaseYear = 2015, Genre = "Biography", Trailer = "/Trailers/Heneral Luna.mp4", Desc= "In 1898, Gen. Antonio Luna (John Arcilla) faces resistance from his own countrymen as he fights for freedom during the Philippine-American War." , Poster = "/Images/Luna.jpg"},
			new MovieViewModel { Id = 7, Name = "The Tomorrow War", Rating = "5", ReleaseYear = 2021, Genre = "Drama", Trailer = "/Trailers/The Tomorrow War.mp4" , Desc = "The world is stunned when a group of time travellers arrive from the year 2051 to deliver an urgent message: thirty years in the future, mankind is losing a global war against a deadly alien species.", Poster = "/Images/Towar.jpg"},
			new MovieViewModel { Id = 8, Name = "Ready Player One", Rating = "5", ReleaseYear = 2018, Genre = "Sci-Fi", Trailer = "/Trailers/Ready P1.mp4" , Desc = "In 2045 the planet is on the brink of chaos and collapse, but people find salvation in the OASIS: an expansive virtual reality universe created by eccentric James Halliday. When Halliday dies, he promises his immense fortune to the first person to discover a digital Easter egg that's hidden somewhere in the OASIS. When young Wade Watts joins the contest, he finds himself becoming an unlikely hero in a reality-bending treasure hunt through a fantastical world of mystery, discovery and danger.", Poster = "/Images/READYP1.jpg"},
			new MovieViewModel { Id = 9, Name = "Battleship", Rating = "5", ReleaseYear = 2012, Genre = "Sci-Fi", Trailer = "/Trailers/Battleship.mp4" , Desc = "Lt. Alex Hopper (Taylor Kitsch) is a weapons officer aboard the destroyer USS John Paul Jones, while his older brother, Stone (Alexander Skarsgård), is the commanding officer of the USS Sampson. Unknown to Alex, Stone or the rest of the U.S. Navy, alien invaders have arrived on Earth with plans to steal Earth's resources. When a confrontation with the invaders knocks out the Navy's radar capability, American and Japanese forces must work together to find a way to save the planet.", Poster = "/Images/Battleship.jpg"},
			new MovieViewModel { Id = 10, Name = "I Am Legend", Rating = "5", ReleaseYear = 2007, Genre = "Horror", Trailer = "/Trailers/Legend.mp4" , Desc = "Robert Neville (Will Smith), a brilliant scientist, is a survivor of a man-made plague that transforms humans into bloodthirsty mutants. He wanders alone through New York City, calling out for other possible survivors, and works on finding a cure for the plague using his own immune blood. Neville knows he is badly outnumbered and the odds are against him, and all the while, the infected wait for him to make a mistake that will deliver Neville into their hands.", Poster = "/Images/Legend.jpg"},
			new MovieViewModel { Id = 11, Name = "Man of Steel", Rating = "5", ReleaseYear = 2013, Genre = "Adventure", Trailer = "/Trailers/Superman.mp4" , Desc = "With the imminent destruction of Krypton, their home planet, Jor-El (Russell Crowe) and his wife seek to preserve their race by sending their infant son to Earth. The child's spacecraft lands at the farm of Jonathan (Kevin Costner) and Martha (Diane Lane) Kent, who name him Clark and raise him as their own son. Though his extraordinary abilities have led to the adult Clark (Henry Cavill) living on the fringe of society, he finds he must become a hero to save those he loves from a dire threat.", Poster = "/Images/Superman.jpg"},
			new MovieViewModel { Id = 12, Name = "Interstellar", Rating = "5", ReleaseYear = 2014, Genre = "Sci-Fi", Trailer = "/Trailers/Interstellar.mp4" , Desc = "In Earth's future, a global crop blight and second Dust Bowl are slowly rendering the planet uninhabitable. Professor Brand (Michael Caine), a brilliant NASA physicist, is working on plans to save mankind by transporting Earth's population to a new home via a wormhole. But first, Brand must send former NASA pilot Cooper (Matthew McConaughey) and a team of researchers through the wormhole and across the galaxy to find out which of three planets could be mankind's new home.", Poster = "/Images/Interstellar.jpg"},
			new MovieViewModel { Id = 13, Name = "Tenet", Rating = "5", ReleaseYear = 2020, Genre = "Thriller", Trailer = "/Trailers/Tenet.mp4" , Desc = "A secret agent is given a single word as his weapon and sent to prevent the onset of World War III. He must travel through time and bend the laws of nature in order to be successful in his mission.", Poster = "/Images/Tenet.jpg"},
			new MovieViewModel { Id = 14, Name = "Dunkirk", Rating = "5", ReleaseYear = 2017, Genre = "History", Trailer = "/Trailers/Dunkirk.mp4" , Desc = "In May 1940, Germany advanced into France, trapping Allied troops on the beaches of Dunkirk. Under air and ground cover from British and French forces, troops were slowly and methodically evacuated from the beach using every serviceable naval and civilian vessel that could be found. At the end of this heroic mission, 330,000 French, British, Belgian and Dutch soldiers were safely evacuated.", Poster = "/Images/Dunkirk.jpg"},
			new MovieViewModel { Id = 15, Name = "The Prestige", Rating = "5", ReleaseYear = 2006, Genre = "Mystery", Trailer = "/Trailers/Prestige.mp4" , Desc = "Period thriller set in Edwardian London where two rival magicians, partners until the tragic death of an assistant during a show, feud bitterly after one of them performs the ultimate magic trick - teleportation. His rival tries desperately to uncover the secret of his routine, experimenting with dangerous new science as his quest takes him to the brink of insanity and jeopardises the lives of everyone around the pair.", Poster = "/Images/Prestige.jpg"},
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

