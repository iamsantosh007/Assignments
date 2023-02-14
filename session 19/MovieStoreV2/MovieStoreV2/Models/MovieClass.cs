using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreV2.Models
{
    [Serializable]
    class MovieClass
    {
        public string name;
        public int year;
        public int id;
        public string genere;

        public MovieClass(string name,int year,string genere,int id)
        {
                this.name = name;
                this.year = year;
                this.genere = genere;
                this.id = id+1;
        }
        public MovieClass()
        {

        }

        public MovieClass onCreate(string name,int year,string genere,int id)
        {
            return new MovieClass(name,year,genere,id);
        }
    }
}
