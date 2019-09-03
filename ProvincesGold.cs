using System;

namespace Kattis
{
	class Provinces
	{
		static void ProvinceBuy()
		{
			string[] hand = Console.ReadLine().Split(' ');
			int handVal = 3 * Int32.Parse(hand[0]) + 2 * Int32.Parse(hand[1]) + Int32.Parse(hand[2]);

			if (handVal >= 8)
				Console.Write("Province");
			else if (handVal >= 5)
				Console.Write("Duchy");
			else if(handVal >= 2)
				Console.Write("Estate");

			if(handVal >= 2)
				Console.Write(" or ");

			if (handVal >= 6)
				Console.WriteLine("Gold");
			else if (handVal >= 3)
				Console.WriteLine("Silver");
			else
				Console.WriteLine("Copper");
		}
	}
}