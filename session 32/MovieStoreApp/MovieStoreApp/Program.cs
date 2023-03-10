using MovieStoreApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MovieStoreApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Folder Movie = new Folder() { Name = "Movie" };

            Movie.AddChild(new FileSystem() { Name = "RandomMovie.Avi", Size = 700 });
            Movie.AddChild(new Folder() { Name = "Action" });

            Folder Comedy = new Folder() { Name = "Comedy" };
            Movie.AddChild(Comedy);
            Comedy.AddChild(new FileSystem() { Name = "Housefull.avi", Size = 700 });
            Comedy.AddChild(new FileSystem() { Name = "HeraPheri", Size = 800 });

            Folder Thriller = new Folder() { Name = "ATB Comedy" };
            Comedy.AddChild(Thriller);
            Thriller.AddChild(new FileSystem() { Name = "Chup chup ke", Size = 700 });
            Thriller.AddChild(new FileSystem() { Name = "Khata Metha", Size = 1200 });
            

           

           
           


            
            Movie.Display();
            Console.WriteLine( "\n\n\n\n");
            Movie.DisplayFolderByIndexOrLevel(2);
            Console.WriteLine("\n\n\n");
            Movie.DisplayFileByIndexOrLevel(3);
            
        }
    }
}