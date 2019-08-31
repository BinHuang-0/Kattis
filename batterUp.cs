using System;

namespace Kattis
{
	class BatterUp
	{
		static void Main()
		{
			int N = Int32.Parse(Console.ReadLine());
			string input = Console.ReadLine();
			int count = 0;
			int sum = 0;

			string[] num = input.Split(' ');

			for(int i = 0; i < N; i++)
			{
				if (Int32.Parse(num[i]) != -1)
				{
					sum += Int32.Parse(num[i]);
					count++;
				}

			}

			Console.WriteLine((float)sum / count);
		}
	}
}