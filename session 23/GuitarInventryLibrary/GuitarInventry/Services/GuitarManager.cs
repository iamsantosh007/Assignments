using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarInventry.Models;

namespace GuitarInventry.Services
{
    public class GuitarManager
    {
       List<Guitar> guitars= new List<Guitar>();

        public void AddGuitar(string serialNumber,double price,GuitarSpec guitarSpec)
        {
            Guitar guitar=new Guitar(serialNumber,price,guitarSpec);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if(serialNumber==guitar.SerialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchGuitar)
        {

            List<Guitar> searchResult = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                int count = 0;
                if (!searchGuitar.Builder.Equals("") && searchGuitar.Builder.Equals(guitar.getSpec.Builder))
                {
                    count++;
                }
                if (!searchGuitar.Type.Equals("") && searchGuitar.Type.Equals(guitar.getSpec.Type))
                {
                    count++;

                }
                if (searchGuitar.Model != null && !searchGuitar.Model.Equals("") && searchGuitar.Model.ToLower().Equals(guitar.getSpec.Model))
                {
                    count++;

                }
                if (!searchGuitar.BackWood.Equals("") && searchGuitar.BackWood.Equals(guitar.getSpec.BackWood))
                {
                    count++;
                }
                if (!searchGuitar.TopWood.Equals("") && searchGuitar.TopWood.Equals(guitar.getSpec.TopWood))
                {
                    count++;
                }
                if (!searchGuitar.NumberOfString.Equals("") && searchGuitar.NumberOfString.Equals(guitar.getSpec.NumberOfString))
                {
                    count++;
                }
                if (count >= 4)
                {
                    searchResult.Add(guitar);
                }

            }
            return searchResult;

        }

    }
}
