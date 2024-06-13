using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignMönster_Labb3.Factories;

namespace DesignMönster_Labb3
{
    // Maskin som hanterar skapandet av varma drycker
    public class WarmDrinkMachine
	{
		private readonly List<Tuple<string, object>> namedFactories; // Lista över fabriker med deras namn

		public WarmDrinkMachine()
		{
			namedFactories = new List<Tuple<string, object>>(); // Initierar listan över fabriker

			// Registrerar fabriker explicit
			RegisterFactory<HotWaterFactory>("Hot Water"); // Registrerar fabriken för varmt vatten
			RegisterFactory<HotChocoFactory>("Chocolate"); // Registrerar fabriken för varm choklad
			RegisterFactory<AmericanoFactory>("Americano"); // Registrerar fabriken för Americano
			RegisterFactory<CappochinoFactory>("Cappochino"); // Registrerar fabriken för Cappochino
		}

		// Metod för att registrera en fabrik
		private void RegisterFactory<T>(string drinkName) where T : new()
		{
			namedFactories.Add(Tuple.Create(drinkName, (object)new T())); // Lägger till fabriken i listan
		}

		// Metod för att skapa en varm dryck
		public IWarmDrink MakeDrink()
		{
			var size = GetCupSize();

			Console.Clear();
			Console.WriteLine("This is what we serve today:");
			for (var index = 0; index < namedFactories.Count; index++)
			{
				var tuple = namedFactories[index];
				Console.WriteLine($"{index}: {tuple.Item1}"); // Skriver ut tillgängliga drycker
			}

			Console.WriteLine("Select a number to continue:");

			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out var i) && i >= 0 && i < namedFactories.Count) // Läser och validerar användarens val
				{
					var factory = namedFactories[i].Item2;
					switch (factory)
					{
						case ICoffeeFactory coffeeFactory:
							var espressoShots = GetValidAmount();
							return coffeeFactory.Prepare(size, espressoShots); // Förbereder och returnerar kaffedrycker

						case IWarmDrinkFactory warmDrinkFactory:
							return warmDrinkFactory.Prepare(size); // Förbereder och returnerar varmt vatten & choklad

						default:
							Console.WriteLine("Something went wrong with your input, try again."); // Meddelande vid felaktig inmatning
							break;
					}
				}
				else
				{
					Console.WriteLine("Something went wrong with your input, try again."); // Meddelande vid felaktig inmatning
				}
			}
		}

		// Metod för att välja koppstorlek
		public static string GetCupSize()
		{
			while (true)
			{
				Console.WriteLine("Choose cup size: [S]mall, [M]edium, [L]arge");
				var size = Console.ReadLine()?.ToLower();

				var validSize = size switch
				{
					"s" => "SMALL",
					"m" => "MEDIUM",
					"l" => "LARGE",
					_ => string.Empty
				};

				if (!string.IsNullOrEmpty(validSize))
				{
					return validSize;
				}
				else
				{
					Console.WriteLine("Invalid cup size. Please enter S, M, or L.");
				}
			}
		}

		// Metod för att validera mängden espresso shots
		public static int GetValidAmount()
		{
			while (true)
			{
				Console.Write("How many espresso shots?: ");
				if (int.TryParse(Console.ReadLine(), out var shots) && shots > 0 && shots < 3)
				{
					return shots;
				}
				else
				{
					Console.WriteLine("Please choose 1 or 2 espresso shots.");
				}
			}
		}
	}
}
