using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreV3.Models
{
    [Serializable]
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Genere { get; set; }
        public int Year { get; set; }
    }
}
