using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
	class Program
	{
		static void Main(string[] args)
		{
			var gameNames = new List<string> { "The Legend of Zelda: A Link to the Past", "Portal", "Rocket League"};
			//string[] gameNames = { "The Legend of Zelda: A Link to the Past", "Portal", "Rocket League" };
			//string gameOne = gameNames[0];
			//int gameOneLength = gameNames[0].Length;

			//string gameTwo = gameNames[1];
			//int gameTwoLength = gameNames[1].Length;
			//int gameThreeLength = gameNames[2].Length;

			//int[] gameNamesLength = { gameOneLength, gameTwoLength, gameThreeLength };

			var nameOrder = gameNames.OrderBy(name => name.Length);
			foreach(string name in nameOrder)
			{
				Console.WriteLine(name);
			}

		}
	}
}
