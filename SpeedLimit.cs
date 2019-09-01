using System;

namespace Kattis
{
	class Speed
	{
		static void SpeedLimit()
		{
			int N;
			int mph;
			int prev, cur;
			string[] input;
			int total;

			do
			{
				total = 0;
				N = Int32.Parse(Console.ReadLine());
				prev = 0;

				for (int i = 0; i < N; i++)
				{
					input = Console.ReadLine().Split(' ');
					mph = Int32.Parse(input[0]);
					cur = Int32.Parse(input[1]);
					total += mph * (cur - prev);
					prev = cur;
				}

				if(N > 0)
					Console.WriteLine(total + " miles");
			} while (N != -1);
		}
	}
}