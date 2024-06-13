using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3.Factories
{
    // Implementerar specifika fabriker för varma drycker
    public class HotWaterFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(string cupSize)
        {
            Console.Clear();
            Console.WriteLine($"***** Preparing a {cupSize} cup of hot water *****");
            Console.WriteLine($"Pouring hot water...");
            return new Water(); // Returnerar en ny instans av Water
        }
    }
}
