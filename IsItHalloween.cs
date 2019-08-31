using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
	class IsItHalloween
	{
		static void Halloween(string[] args)
		{
			string[] l = Console.ReadLine().Split(' ');

			string m = l[0];
			int d = Int32.Parse(l[1]);

			if ((string.Compare("OCT", m) == 0 && d == 31) || (string.Compare("DEC", m) == 0 && d == 25))
				Console.WriteLine("yup");
			else
				Console.WriteLine("nope");
		}
	}
}
