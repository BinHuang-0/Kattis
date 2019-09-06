using System;

namespace Kattis {
	class Soy {
		static void Main() {
			int T = Int32.Parse(Console.ReadLine());
			int cal;

			for(int i = 0; i < T; i++) {
				cal = Int32.Parse(Console.ReadLine());
				Console.WriteLine(Math.Ceiling((double)cal / 400));
			}
		}
	}
}