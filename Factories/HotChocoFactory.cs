using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3.Factories
{
    public class HotChocoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(string cupSize)
        {
            Console.Clear();
            Console.WriteLine($"***** A {cupSize} Hot Chocolate coming up! *****");
            Console.WriteLine($"Adding yummy chocolate...");
            Console.WriteLine($"Pouring hot water...");
            return new Chocolate(); // Returnerar en ny instans av Varm choklad
        }
    }
}
