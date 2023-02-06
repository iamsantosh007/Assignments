using MovieStoreApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Services
{
    class MovieService
    {
        private int _arraySize;
        private int _arrayLowerBound;
        private int _arrayUpperBound;

        public MovieStore[] _movies;


        private static bool HasSufficientSpace(MovieStore[] movies)
        {

            int count = 0;
            foreach (var movie in movies)
            {
                if (movie != null)
                {
                    count++;
                }
                if (movie == null)
                {
                    break;
                }
            }
            if (count == movies.Length)
            {
                return false;
            }
            return true;
        }
        public void AddMovie()
        {
            if (!HasSufficientSpace(this._movies))
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("already having Maximum movie list");
                Console.WriteLine("------------------------------------");
                if (IncreaseMovieListSize())
                {
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("Hurrey! you update the movieList and you are ready to enter the Movie:-");
                    Console.WriteLine("-------------------------------------------------------------------");

                }
                return;

            }
            Random r = new Random();

            int id = r.Next(this._arrayLowerBound, this._arrayUpperBound);
            while (Find(id, _movies))
            {
                id = r.Next(this._arrayLowerBound, this._arrayUpperBound);
            }

            Console.WriteLine("Enter the movie Name:-");
            string name = Console.ReadLine();
            while (!HasNameCorrectFormat(name))
            {
                Console.WriteLine("Enter the movie Name:-");
                name = Console.ReadLine();
            }

            Console.WriteLine("Enter the movie Genere:-");
            string genere = Console.ReadLine();
            while (!HasGenereCorrectFormat(genere))
            {
                Console.WriteLine("Enter the movie Genere:-");
                genere = Console.ReadLine();
            }

            Console.WriteLine("Enter the Year:-");
            int year = Convert.ToInt32(Console.ReadLine());

            MovieStore movie = new MovieStore(id, name, genere, year);
            for (int i = 0; i < _movies.Length; i++)
            {
                if (_movies[i] == null)
                {
                    _movies[i] = movie;
                    Console.WriteLine();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Yeh! Movie Created");
                    Console.WriteLine("----------------------");
                    break;
                    //SerializeMovie(_movies);
                }
            }


        }

        private bool HasNameCorrectFormat(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            return true;
        }

        private bool HasGenereCorrectFormat(string genere)
        {
            if (string.IsNullOrEmpty(genere))
            {
                return false;
            }
            return true;
        }

        private bool IncreaseMovieListSize()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("If you want to increase movie Size press Y and press N for No change in List");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.Write("enter your choice:- ");
            char c = Convert.ToChar(Console.ReadLine().ToLower());
            switch (c)
            {
                case 'y':

                    MovieStore[] movieUpdateLength = new MovieStore[_arraySize * 2];
                    for (int i = 0; i < movieUpdateLength.Length; i++)
                    {
                        if (i > _arraySize - 1)
                        {
                            break;
                        }
                        if (movieUpdateLength[i] == null)
                        {
                            movieUpdateLength[i] = _movies[i];
                        }
                    }

                    _movies = movieUpdateLength;
                    _arraySize = _movies.Length;
                    this._arrayLowerBound = this._arrayUpperBound;
                    this._arrayUpperBound = _movies.Length + 1;
                    return true;
                case 'n':
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("you choose to not update the list");
                    Console.WriteLine("------------------------------------");
                    return false;


            }
            return false;
        }

        public void DisplayMovie()
        {
            foreach (var movie in _movies)
            {
                if (movie == null)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("MovieList end");
                    Console.WriteLine("----------------");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine($"Movie id is:-{movie.ID}\n" +
                    $"Movie Name is :- {movie.Name}\n" +
                    $"Movie Genere is :- {movie.Genere}\n" +
                    $"Movie Year is :- {movie.Year}");
                Console.WriteLine("------------------------------------");
            }
        }
        private static bool Find(int id, MovieStore[] movies)
        {
            //if(movies==null|| movies.Length == 0)
            //{
            //    return false;
            //}
            foreach (var movie in movies)
            {
                if (movie == null)
                {
                    return false;
                }
                if (movie.ID == id)
                {
                    return true;
                }
            }
            return false;
        }



        public void ClearMovie()
        {
            _movies = new MovieStore[5];
        }

        public int MovieCount()
        {
            int count = 0;
            foreach (var movie in _movies)
            {
                if (movie != null)
                {
                    count++;
                }
            }
            return count;

        }

        public MovieStore[] Movies { get { return _movies; } set { _movies = value; } }

        public int ArraySize { set { _arraySize = value; } get { return _arraySize; } }
        public int ArrayLowerBound { get { return _arrayLowerBound; } set { _arrayLowerBound = value; } }
        public int ArrayUpperBound { get { return _arrayUpperBound; } set { _arrayUpperBound = value; } }
    }
}
