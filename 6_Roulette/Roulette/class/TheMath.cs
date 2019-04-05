using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{

	public class TheMath
	{
		NumberGen gen = new NumberGen();

		public int up { get; set; }
		public int upright { get; set; }
		public int right { get; set; }
		public int left { get; set; }
		public int upleft { get; set; }
		public int down { get; set; }
		public int downleft { get; set; }
		public int downright { get; set; }
		public int upup { get; set; }
		public int dowdow { get; set; }
		public int upupright { get; set; }
		public int dowdowright { get; set; }
		public int dowdowleft { get; set; }

		public TheMath()
		{
			Cal();
		}

		public void Cal()
		{
			int Check = gen.RanNumber;

			 up = (Check + 1);
			 upright = (Check + 4);
			 right = (Check + 3);
			 left = (Check - 3);
			 upleft = (Check - 2);
			 down = (Check - 1);
			 downleft = (Check - 4);
			 downright = (Check + 2);

			 upup = (Check + 2);
			 dowdow = (Check - 2);
			 upupright = (Check + 5);
			 dowdowright = (Check - 5);
			 dowdowleft = (Check - 5);
		}
	}
}

	


