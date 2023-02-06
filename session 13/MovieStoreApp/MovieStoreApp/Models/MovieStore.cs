using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Models
{
    [Serializable]
    class MovieStore
    {
        private int _id;
        private string _name;
        private string _genere;
        private int _year;

        public MovieStore(int id, string name, string genere, int year)
        {
            this._id = id;
            this._name = name;
            this._genere = genere;
            this._year = year;
        }

        public int ID { get { return _id; } }
        public string Name { get { return _name; } }

        public string Genere { get { return _genere; } }

        public int Year { get { return _year; } }

        //public MovieStore CreateMovie(int id,string name,string genere,int year) 
        //{ 
        //    return new MovieStore(id,name,genere,year);
        //}

        
    }
}
