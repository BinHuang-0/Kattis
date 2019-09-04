using System;

namespace Kattis
{
	class NumberFun
	{
		static void Main()
		{
			int N = Int32.Parse(Console.ReadLine());
			string[] input;

			for(int i = 0; i < N; i++)
			{
				input = Console.ReadLine().Split(' ');
				if (
					Int32.Parse(input[0]) + Int32.Parse(input[1]) == Int32.Parse(input[2]) ||
					Int32.Parse(input[0]) - Int32.Parse(input[1]) == Int32.Parse(input[2]) ||
					Int32.Parse(input[0]) * Int32.Parse(input[1]) == Int32.Parse(input[2]) ||
					(float)Int32.Parse(input[0]) / (float)Int32.Parse(input[1]) == (float)Int32.Parse(input[2]) ||
					Int32.Parse(input[1]) + Int32.Parse(input[0]) == Int32.Parse(input[2]) ||
					Int32.Parse(input[1]) - Int32.Parse(input[0]) == Int32.Parse(input[2]) ||
					Int32.Parse(input[1]) * Int32.Parse(input[0]) == Int32.Parse(input[2]) ||
					(float)Int32.Parse(input[1]) / (float)Int32.Parse(input[0]) == (float)Int32.Parse(input[2]) 
					)
					Console.WriteLine("Possible");

				else
					Console.WriteLine("Impossible");
				
			}
		}
	}
}