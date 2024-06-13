using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3.Factories
{
    public class CappochinoFactory : ICoffeeFactory
    {
        public IWarmDrink Prepare(string cupSize, int espressoShots)
        {
            Console.Clear();
            Console.WriteLine($"***** A {cupSize} Cappochino with {espressoShots} espresso shot(s) coming up! *****");
            Console.WriteLine($"Adding {espressoShots} espresso shot(s)...");
            Console.WriteLine($"Frothing milk...");
            Console.WriteLine($"Pouring milk...");
            return new Cappochino(); // Returnerar en ny instans av Cappochino
        }
    }
}
