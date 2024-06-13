using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3.Factories
{
    // Definierar ett interface för fabriker som kan skapa varma drycker
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(string cupSize); // Drycker utan kaffe
    }
}
