using System;

namespace Kattis
{
	class MicHiss
	{
		static void Main()
		{
			string input = Console.ReadLine();
			int hiss = 0;

			for(int i = 0; i < input.Length - 1; i++)
			{
				if (input.Substring(i, 1) == input.Substring(i + 1, 1) && input.Substring(i,1) == "s")
				{
					hiss = 1;
				}
			}

			if (hiss == 1)
				Console.WriteLine("hiss");
			else
				Console.WriteLine("no hiss");
		}
	}
}