using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarInventry.Services;
using GuitarInventry.Models;



namespace GuitarInventry
{
    public class Test
    {
        public static void Main(string[] args)
        {
            //CaseStudyOne();
            //CaseStudyTwo();
            CaseStudyThree();
            Console.ReadLine();
        }
        //public static void CaseStudyOne()
        //{
        //    Inventry guitarManager = new Inventry();
        //    guitarManager.AddGuitar("101", 500d, Builder.COLLING, "v5rt", TypeOfGuitar.ACOUSTIC, BackWood.COCOBOLO_ROSEWOOD, TopWood.PERK_SANDLEWOOD);


        //    Guitar guitarSearch = new Guitar("101", 500d, Builder.COLLING, "v5rt", TypeOfGuitar.ACOUSTIC, BackWood.COCOBOLO_ROSEWOOD, TopWood.PERK_SANDLEWOOD);
        //    Guitar guitar = guitarManager.Search(guitarSearch);
        //    if (guitar == null)
        //        Console.WriteLine("we have nothing for you");
        //    if (guitar != null)
        //        Console.WriteLine(guitar.Model + " " + guitar.Price + " " + guitar.TopWood + " " + guitar.BackWood + " " + guitar.Builder + " " + guitar.SerialNumber + " " + guitar.Type);
        //}

        //private static void CaseStudyTwo()
        //{
        //    Inventry guitarManager = new Inventry();
        //    GuitarSpec guitarSpec = new GuitarSpec("v5rt", Builder.COLLING, TypeOfGuitar.ACOUSTIC, BackWood.COCOBOLO_ROSEWOOD, TopWood.PERK_SANDLEWOOD);
        //    guitarManager.AddGuitar("101", 500d,guitarSpec);
        //    GuitarSpec guitarSpec2 = new GuitarSpec("bjrt", Builder.COLLING, TypeOfGuitar.ACOUSTIC, BackWood.COCOBOLO_ROSEWOOD, TopWood.PERK_SANDLEWOOD);
        //    guitarManager.AddGuitar("102", 485d, guitarSpec2);
        //    GuitarSpec guitarSearch = new GuitarSpec("vghj",Builder.FENDER,TypeOfGuitar.ACOUSTIC,BackWood.COCOBOLO_ROSEWOOD,TopWood.PERK_SANDLEWOOD); 
        //    List<Guitar> guitars = guitarManager.Search(guitarSearch);
        //    foreach (var guitar in guitars)
        //    {
        //        Console.WriteLine(guitar.getSpec.Model + " " + guitar.Price + " " + guitar.getSpec.Type + " " + guitar.getSpec.BackWood + " " + guitar.getSpec.TopWood + " " + guitar.SerialNumber+" "+guitar.getSpec.Builder);
        //    }
        //}


        public static void CaseStudyThree()
        {
            Inventry guitarManager= new Inventry();   
            GuitarSpec guitarSpec=new GuitarSpec("bugatti-600",12,Builder.FENDER,TypeOfGuitar.ELECTRIC,BackWood.COCOBOLO_ROSEWOOD,TopWood.PERK_SANDLEWOOD);
            guitarManager.AddGuitar("101",5000d,guitarSpec);
            GuitarSpec guitarSpec2 = new GuitarSpec("bjrt", 6,Builder.COLLING, TypeOfGuitar.ACOUSTIC, BackWood.COCOBOLO_ROSEWOOD, TopWood.PERK_SANDLEWOOD);
            guitarManager.AddGuitar("102", 485d, guitarSpec2);
            GuitarSpec guitarSearch = new GuitarSpec("vghj", 6,Builder.FENDER, TypeOfGuitar.ACOUSTIC, BackWood.COCOBOLO_ROSEWOOD, TopWood.PERK_SANDLEWOOD);
            List<Guitar> guitars = guitarManager.Search(guitarSearch);
            foreach(var guitar in guitars)
            {
                Console.WriteLine(guitar.getSpec.Model + " "+ guitar.getSpec.NumberOfString+" " + guitar.Price + " " + guitar.getSpec.Type + " " + guitar.getSpec.BackWood + " " + guitar.getSpec.TopWood + " " + guitar.SerialNumber + " " + guitar.getSpec.Builder);
            }

        }





    }
}
