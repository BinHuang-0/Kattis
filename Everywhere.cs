using System;

namespace Kattis
{
	class Everywhere
	{
		static void Main()
		{
			int T = Int32.Parse(Console.ReadLine());
			int N;

			string[] cities = new string[100];
			int uni;
			Boolean same;

			for (int i = 0; i < T; i++)
			{
				N = Int32.Parse(Console.ReadLine());

				uni = 0;
				for(int k = 0; k < N; k++)
				{
					cities[k] = Console.ReadLine();
					same = false;
					for(int j = 0; j < k; j++)
						if (cities[j] == cities[k])
							same = true;

					if(same == false)
						uni++;
				}
				Console.WriteLine(uni);
			}
		}
	}
}