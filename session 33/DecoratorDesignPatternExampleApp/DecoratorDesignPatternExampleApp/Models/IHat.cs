using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternExampleApp.Models
{
    public interface IHat
    {
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        void NameOfProduct();
        void PriceOfProduct();
        void DescriptionOfProduct();

    }
}
