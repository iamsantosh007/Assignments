using MovieStoreV2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreV2
{

    class Program
    {

        
        //public static BinaryFormatter formatter10 = new BinaryFormatter();
       
        
        public static int idN = 0;
        
        static void Main(string[] args)
        {
            List<MovieClass> movieList = DeserializeMovieList();
        
            BinaryFormatter formatter = new BinaryFormatter();
            MovieClass movieClassVar = new MovieClass();
            bool start = true;
            Console.WriteLine($"Welcome to movie store,Developed by santosh");
            

            while (start)
            {   ChangeFontColourForMenuLabels();
                Console.WriteLine($"\t\tMovie count is " + movieList.Count + "/5\n" +
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
                        AddMovie(movieList);
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


        public static void DisplayAllMovies(List<MovieClass> movieList)
        {
            foreach (var movieClassVarw in movieList)
            {
                Console.WriteLine("Id is " + movieClassVarw.id + " movie name " + movieClassVarw.name + " and genere is " + movieClassVarw.genere + " movie year is " + movieClassVarw.year);
            }
        }
        public static List<MovieClass> DeserializeMovieList()
        {

            using (FileStream filepath = new FileStream("E:\\Swabhav Assignments\\session 19\\MovieStoreV2\\MovieClass.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter10 = new BinaryFormatter();
                if (filepath.Length > 0)
                {
                    return (List<MovieClass>)formatter10.Deserialize(filepath);
                }
            }
            return new List<MovieClass>();
        }

        public static void AddMovie(List<MovieClass> movieList)
        {
            if (movieList.Count >= 5)
            {
                Console.WriteLine("You Reach Limit");
                return;
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

            MovieClass dataStore = new MovieClass().onCreate(name, year, movieGenere, movieList.Count);
            movieList.Add(dataStore);
            ChangeFontColourForResult();
            Console.WriteLine("\t\t\t--Movie Added Successfully--");
            Console.ResetColor();
        }

        public static void SerializedList(List<MovieClass> movieList)
        {
            using (FileStream filepath = new FileStream("E:\\Swabhav Assignments\\session 19\\MovieStoreV2\\MovieClass.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter10 = new BinaryFormatter();
                formatter10.Serialize(filepath, movieList);
                Environment.Exit(-1);
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
            Console.ForegroundColor= ConsoleColor.DarkYellow;
        }
    }
}
