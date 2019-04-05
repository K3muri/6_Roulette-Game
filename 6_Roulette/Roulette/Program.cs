using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
	class Program
	{
		static void Main(string[] args)
		{
			Work DoWork = new Work();
			Result result = DoWork.ary();

			DoWork.Numbers();

			DoWork.EVensOdds();

			DoWork.RedBlacks(result);

			DoWork.LowsHighs();

			DoWork.Dozens();

			DoWork.Columns();

			DoWork.StreetRows();

			DoWork.DoubleRows();

			DoWork.Split();

			DoWork.Corner();

			Console.ReadLine();
		}
	}
}
