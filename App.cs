using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMönster_Labb3
{
	public class App
	{
		public void Run()
		{
			var machine = new WarmDrinkMachine(); // Skapar en instans av WarmDrinkMachine

			while (true)
			{
				PrintHeader();
				IWarmDrink drink = machine.MakeDrink(); // Skapar en dryck
				drink.Consume(); // Konsumerar drycken

				Console.WriteLine("\n\n\n----------\nDo you want to order another drink? \n" +
				                  "(Press any key to continue or 'q' to exit)");
				if (Console.ReadLine()?.ToLower() == "q")
				{
					break;
				}
			}
		}

		public void PrintHeader()
		{
			Console.Clear();
			Console.WriteLine("*********************************");
			Console.WriteLine("* Welcome to Drink-o-Matic-3000 *");
			Console.WriteLine("*********************************");
		}
	}
}
