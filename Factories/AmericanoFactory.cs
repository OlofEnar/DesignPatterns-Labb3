using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3.Factories
{
    public class AmericanoFactory : ICoffeeFactory
    {
        public IWarmDrink Prepare(string cupSize, int espressoShots)
        {
            Console.Clear();
            Console.WriteLine($"***** A {cupSize} Americano with {espressoShots} espresso shot(s) coming up! *****");
            Console.WriteLine($"Adding {espressoShots} espresso shot(s)...");
            Console.WriteLine($"Pouring hot water...");
            return new Americano(); // Returnerar en ny instans av Americano
        }
    }
}
