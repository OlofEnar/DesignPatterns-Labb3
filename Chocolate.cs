using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3
{
	public class Chocolate : IWarmDrink
	{
		public void Consume()
		{
			Console.WriteLine("Hot choco is served.");
		}
	}
}
