using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
	public class NumberGen
	{
		public int RanNumber { get; set; }

		public NumberGen()
		{
			RNumberGen();
		}

		public void RNumberGen()
		{
			Random RNG = new Random();
			RanNumber = RNG.Next(38);
		}
	}

	public class Result
	{
		public string Color { get; set; }
	}
}
