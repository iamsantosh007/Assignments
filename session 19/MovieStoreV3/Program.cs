using MovieStoreV3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreV3
{
    public class Program
    {
        //private static int limit;
        static void Main(string[] args)
        {
            
            List<Movie> movieList = DeserializeMovieList();
            int limit = 0;
            limit = movieList.Count <= 5 ? 5 : movieList.Count;

            bool start = true;
            Console.WriteLine($"Welcome to movie store,Developed by santosh");


            while (start)
            {
                ChangeFontColourForMenuLabels();
                Console.WriteLine($"\t\tMovie count is " + movieList.Count + $"/{limit}\n" +
                     "\t\t1-Add movie\n" +
                      "\t\t2-Display Movies\n" +
                      "\t\t3-clear all movies\n" +
                      "\t\t4-exit");
                Console.ResetColor();

                Console.Write("enter your choice:- ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("\t\t\t------------------------");
                        AddMovie(movieList,limit);
                        Console.WriteLine("\t\t\t------------------------");
                        break;

                    case 2:

                        DisplayAllMovies(movieList);
                        break;
                    case 3:
                        movieList.Clear();
                        break;
                    case 4:
                        start = false;
                        SerializedList(movieList);
                        break;
                }
            }
            Console.ReadLine();
        }
        public static List<Movie> DeserializeMovieList()
        {

            using (FileStream filepath = new FileStream("E:\\Swabhav Assignments\\session 19\\MovieStoreV2\\MovieClass.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter10 = new BinaryFormatter();
                if (filepath.Length > 0)
                {
                    return (List<Movie>)formatter10.Deserialize(filepath);
                }
            }
            return new List<Movie>();
        }
        public static void SerializedList(List<Movie> movieList)
        {
            using (FileStream filepath = new FileStream("E:\\Swabhav Assignments\\session 19\\MovieStoreV2\\MovieClass.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter10 = new BinaryFormatter();
                formatter10.Serialize(filepath, movieList);
                Environment.Exit(-1);
            }
        }

        public static void AddMovie(List<Movie> movieList,int limit)
        {
            if (movieList.Count == limit)
            {
                Console.WriteLine("You Reach Limit");
                if (IncreasedArraySize(movieList,limit))
                {
                    Console.WriteLine("Bingo you choose to increase array");

                }
                else
                {
                    return;
                }
                
            }
            ChangeFontColourForAddMovieLabels();
            Console.Write("\t\t\tEnter the movie name:- ");
            ChangeColourForAddMovieInput();
            string name = Console.ReadLine();

            ChangeFontColourForAddMovieLabels();
            Console.Write("\t\t\tEnter the movie year:- ");
            ChangeColourForAddMovieInput();
            int year = Convert.ToInt32(Console.ReadLine());

            ChangeFontColourForAddMovieLabels();
            Console.Write("\t\t\tEnter the movie genere:- ");
            ChangeColourForAddMovieInput();
            string movieGenere = Console.ReadLine();

            Movie dataStore = new Movie() { Id=movieList.Count,Name=name,Year=year,Genere=movieGenere};
            movieList.Add(dataStore);
            ChangeFontColourForResult();
            Console.WriteLine("\t\t\t--Movie Added Successfully--");
            Console.ResetColor();
        }

        private static bool IncreasedArraySize(List<Movie> movie,int limit)
        {
            Console.Write("if you want to increase movie size press Y or N to exit");
            char c=Convert.ToChar(Console.ReadLine().ToUpper());
            if (c == 'Y')
            {
                limit = limit * 2;
                return true;
            }
            Console.WriteLine("You choose to leave");
            return false;

        }

        public static void DisplayAllMovies(List<Movie> movieList)
        {
            foreach (var movieClassVarw in movieList)
            {
                ChangeColourForDisplay();
                Console.WriteLine("\t\t\t\t\t\tMovie Details:-");
                Console.WriteLine("\t\t\t\t\t\tId is " + movieClassVarw.Id + "\n\t\t\t\t\t\tmovie name " + movieClassVarw.Name + " \n\t\t\t\t\t\tgenere is " + movieClassVarw.Genere+ " \n\t\t\t\t\t\tmovie year is " + movieClassVarw.Year);
                Console.ResetColor() ;
            }
        }
        private static void ChangeFontColourForResult()
        {
            Console.ForegroundColor = ConsoleColor.Green;

        }

        private static void ChangeFontColourForAddMovieLabels()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        private static void ChangeColourForAddMovieInput()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

        }

        private static void ChangeFontColourForMenuLabels()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        private static void ChangeColourForDisplay() { 
        Console.ForegroundColor= ConsoleColor.DarkCyan;
        }
    }
}
