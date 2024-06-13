using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3.Factories
{
    public interface ICoffeeFactory
    {
        IWarmDrink Prepare(string cupSize, int espressoShots); // Drycker med kaffe
    }
}
