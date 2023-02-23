using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionBirdExample.Models
{
    public class Ostrich : Bird
    {
        public Ostrich(string birdName,string birdSpecies):base(birdName, birdSpecies){}
        public override string GetBirdDetails()
        {
            return $"BirdName is {BirdName} and species is {BirdSpecies}";
        }
    }
}
