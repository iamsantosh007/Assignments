using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionBirdExample.Models
{
    internal class Sparrow : Bird, IFly
    {
        public Sparrow(string birdName, string birdSpecies) : base(birdName, birdSpecies)
        {
        }
        public string Fly()
        {
            return $"{BirdName} is fly";
        }

        public override string GetBirdDetails()
        {
            return $"BirdName is {BirdName} and species is {BirdSpecies}";
        }
    }
}
