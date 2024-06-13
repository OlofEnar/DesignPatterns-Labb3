using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3
{
	public class Americano : IWarmDrink
	{
		public void Consume()
		{
			Console.WriteLine("Americano is served.");
		}
	}
}
