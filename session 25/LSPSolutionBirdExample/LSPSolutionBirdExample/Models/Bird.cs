using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionBirdExample.Models
{
    public abstract class Bird
    {
        private string _birdName;
        private string _birdSpecies;
        public Bird(string birdName,string birdSpecies)
        {
            _birdSpecies= birdSpecies;
            _birdName = birdName;
        }
        public string BirdName { get { return _birdName; }}
        public string BirdSpecies { get { return _birdSpecies; }}

        public abstract string GetBirdDetails();
    }
}
