using System;
namespace Kattis
{
	class Aah {
		static void Aaaah()
		{
			string j = Console.ReadLine();
			string d = Console.ReadLine();

			if (j.Length < d.Length)
				Console.WriteLine("no");
			else
				Console.WriteLine("go");
		}
	}
}