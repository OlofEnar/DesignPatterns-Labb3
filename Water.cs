using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3
{
	// Implementerar specifika varma drycker
	public class Water : IWarmDrink
	{
		public void Consume()
		{
			Console.WriteLine("Warm water is served.");
		}
	}
}
