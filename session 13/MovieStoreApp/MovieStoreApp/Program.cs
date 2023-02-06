using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Models;
using MovieStoreApp.Services;

namespace MovieStoreApp
{
    class Program
    {
        

       
        //static void Main(string[] args)
        //{
        //    MovieService movieService=new MovieService();
            
        //    bool start = true;
        //    Console.WriteLine("Enter in Bollywood MovieSection Developed By Santosh Patro:- ");
        //    movieService.Movies = DeserializeMovie(movieService);
        //    movieService.ArraySize = movieService.Movies.Length;
        //    movieService.ArrayLowerBound = (movieService.ArraySize <= 5) ? 1 : (movieService.ArraySize / 2);
        //    movieService.ArrayUpperBound = movieService.ArraySize + 1;
        //    while (start)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"Movies Count is {movieService.MovieCount()}/{movieService.Movies.Length}");
        //        Console.WriteLine("1-Add\n" +
        //            "2-Display\n" +
        //            "3-Clear\n" +
        //            "4-Exit");
        //        Console.WriteLine("------------------------------------------------");
        //        Console.WriteLine("enter your choice:- ");
        //        int choice=Convert.ToInt32(Console.ReadLine());
        //        switch(choice)
        //        {
        //            case 1:
        //                try
        //                {
        //                    movieService.AddMovie();
        //                } catch (Exception ex) 
        //                { 
        //                    Console.WriteLine("please enter in correct format");
        //                    Console.WriteLine();
        //                    movieService.AddMovie();
        //                }
        //                break;
        //            case 2:
        //                movieService.DisplayMovie();
        //                break;
        //                case 3:
        //                movieService.ClearMovie();
        //                SerializeMovie(movieService.Movies);
        //                break;
        //            case 4:
        //                var movieArray=movieService.Movies;
        //                SerializeMovie(movieArray);
        //                start = false;
        //                break;

        //        }
        //    }
        //}
        //private static void SerializeMovie(MovieStore[] movieStore)
        //{
        //    using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 13\\Movie.txt", FileMode.OpenOrCreate))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, movieStore);
        //    }
        //}

        //private static MovieStore[] DeserializeMovie(MovieService movieServiceForArraySize)
        //{
        //    using (FileStream stream = new FileStream("E:\\Swabhav Assignments\\session 13\\Movie.txt", FileMode.OpenOrCreate))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        if(stream.Length > 0) 
        //        { 
        //                MovieStore[] movie = (MovieStore[])formatter.Deserialize(stream);
                        
 
        //                return movie;
                
        //        }
        //        return new MovieStore[5];
        //    }
        //}
    }
}
