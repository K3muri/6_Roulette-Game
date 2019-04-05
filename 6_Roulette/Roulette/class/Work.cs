using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
	public class Work
	{
		NumberGen gen = new NumberGen();
		TheMath DoMath = new TheMath();
		

		

		int[] red   = { 0, 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
		int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35, 37 };

		int[] Rows1 = { 4, 7, 10, 13, 16, 19, 22, 25, 28, 31 };
		int[] Rows2 = { 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 };
		int[] Rows3 = { 6, 9, 12, 15, 18, 21, 24, 27, 30, 33 };

		int[] side1 = { 1, 2, 3 };
		int[] side2 = { 34, 35, 36 };

		

		public Result ary()
		{
			Result result = new Result();

			int Check = gen.RanNumber;

			foreach (int x in red)
			{
				if (x.Equals(Check))
				{
					result.Color = "Red";
				}
			}

			foreach (int x in black)
			{
				if (x.Equals(Check))
				{
					result.Color = "Black";
				}
			}
			return result;
		}

		public void Numbers()
		{
			int RGN = gen.RanNumber;

			if (RGN == 0 )
			{
				Console.WriteLine($" The number of the bin {RGN} \n");
				
				Console.ReadLine();
				Environment.Exit(0);
			}

			else if (RGN == 37)
			{
				Console.WriteLine($" The number of the bin 00 \n");
				Console.ReadLine();
				Environment.Exit(0);
			}
			else
			{
				Console.WriteLine($"the number of the bin {RGN} \n");
			}
		}

		public void EVensOdds()
		{
			int RGN = gen.RanNumber;

			if (RGN % 2 == 0)
			{
				Console.Write("Number is an Even \n");
			}
			else
			{
				Console.Write("Number is an Odd \n");
			}
		}

		public void RedBlacks(Result result)
		{
			if (result.Color.Equals("red", StringComparison.InvariantCultureIgnoreCase))
			{
				Console.WriteLine("\nThis number is Red \n");
			}
			if (result.Color.Equals("black", StringComparison.InvariantCultureIgnoreCase))
			{
				Console.WriteLine("\nThis number is black \n");
			}
		}

		public void LowsHighs()
		{
			int RGN = gen.RanNumber;

			if (RGN >= 19)
			{
				Console.WriteLine("this is a hight number \n");
			}
			else
			{
				Console.WriteLine("this is a low number \n");
			}
		}

		public void Dozens()
		{
			int RGN = gen.RanNumber;

			if (RGN <=12)
			{
				Console.WriteLine("Number fall in the '1st' block \n");
			}
			else if (RGN>=25)
			{
				Console.WriteLine("number fall in the '3rd' block \n");
			}
			else
			{
				Console.WriteLine("number fall in the '2nd' block \n");
			}
		}

		public void Columns()
		{
			int NUM = gen.RanNumber;

			foreach (int x in Rows1)
			{
				if (x.Equals(NUM))
				{
					Console.WriteLine("This falls in the 1st Columns \n");
				}
			}

			foreach (int x in Rows2)
			{
				if (x.Equals(NUM))
				{
					Console.WriteLine("This falls in the 2nd Columns \n");
				}
			}

			foreach (int x in Rows3)
			{
				if (x.Equals(NUM))
				{
					Console.WriteLine("This falls in the 3rd Columns \n");
				}
			}

			if (NUM == 1 || NUM == 34)
			{
				Console.WriteLine("This falls in the 1st Columns \n");
			}
			else if (NUM == 2 || NUM == 35)
			{
				Console.WriteLine("This falls in the 2nd Columns \n");
			}
			else if (NUM == 3 || NUM == 36)
			{
				Console.WriteLine("This falls in the 3rd Columns \n");
			}
		}

		public void StreetRows()
		{
			int Check = gen.RanNumber;
		
			foreach (int x in Rows1)
			{
				if (x.Equals(Check))
				{
					Console.WriteLine($"Street are {Check}/{DoMath.up}/{DoMath.upup} \n");
				}
			}

			foreach (int x in Rows2)
			{
				if (x.Equals(Check))
				{
					Console.WriteLine($"Street are {Check}/{DoMath.up}/{DoMath.down} \n");
				}
			}

			foreach (int x in Rows3)
			{
				if (x.Equals(Check))
				{
					Console.WriteLine($"Street are {Check}/{DoMath.down}/{DoMath.dowdow} \n");
				}
			}

			if (Check == 1 || Check == 34)
			{
				Console.WriteLine($"Street are {Check}/{DoMath.up}/{DoMath.upup} \n");
			}
			else if (Check == 2 || Check == 35)
			{
				Console.WriteLine($"Street are {Check}/{DoMath.up}/{DoMath.down} \n");
			}
			else if (Check == 3 || Check == 36)
			{
				Console.WriteLine($"Street are {Check}/{DoMath.down}/{DoMath.dowdow} \n");
			}
			
		}

		public void DoubleRows()
		{
			int Check = gen.RanNumber;

			foreach (int x in Rows1)
			{
				if (x.Equals(Check))
				{
					Console.WriteLine($"possible Double Rows can be {Check}/{DoMath.up}/{DoMath.upup}/{DoMath.left}/{DoMath.upleft}/{DoMath.down}" +
						                                       $" 0r {Check}/{DoMath.up}/{DoMath.upup}/{DoMath.right}/{DoMath.upright}/{DoMath.upupright} \n");
				}
			}

			foreach (int x in Rows2)
			{
				if (x.Equals(Check))
				{
					Console.WriteLine($"possible Double Rows can be{Check}/{DoMath.up}/{DoMath.down}/{DoMath.upright}/{DoMath.right}/{DoMath.downright}" +
					                	                      $" or {Check}/{DoMath.up}/{DoMath.down}/{DoMath.upleft}/{DoMath.left}/{DoMath.downleft} \n");
				}
			}

			foreach (int x in Rows3)
			{
				if (x.Equals(Check))
				{
					Console.WriteLine($"possible Double Rows can be {Check}/{DoMath.down}/{DoMath.dowdow}/{DoMath.left}/{DoMath.downleft}/{DoMath.dowdowleft}" +
					                                          $" or {Check}/{DoMath.down}/{DoMath.dowdow}/{DoMath.right}/{DoMath.downright}/{DoMath.dowdowright} \n");
				}
			}
		}

		public void Split()
		{
			int Check = gen.RanNumber;

			foreach (int b in Rows1 )
			{
				if (b.Equals(Check))
				{
					Console.WriteLine($"possible splits are {Check}/{DoMath.up} or {Check}/{DoMath.left} or {Check}/{DoMath.right} \n");
				}
			}

			foreach (int b in Rows2)
			{
				if (b.Equals(Check))
				{
					Console.WriteLine($"possible splits are {Check}/{DoMath.up} or {Check}/{DoMath.left} or {Check}/{DoMath.down} or {Check}/{DoMath.right} \n");
				}
			}

			foreach (int b in Rows3)
			{
				if (b.Equals(Check))
				{
					Console.WriteLine($"possible splits are {Check}/{DoMath.down} or {Check}/{DoMath.left} or {Check}/{DoMath.right} \n");
				}
			}

			if (Check == 1)
			{
				Console.WriteLine($"possible splits are {Check}/{DoMath.up} or {Check}/{DoMath.right} \n");
			}
			else if (Check == 2)
			{
				Console.WriteLine($"possible splits are {Check}/{DoMath.up} or {Check}/{DoMath.down} or {Check}/{DoMath.right} \n");
			}
			else if (Check == 3)
			{
				Console.WriteLine($"possible splits are {Check}/{DoMath.down} or {Check}/{DoMath.right} \n");
			}
			else if (Check == 34)
			{
				Console.WriteLine($"possible splits are {Check}/{DoMath.up}  or {Check}/{DoMath.left} \n");
			}
			else if (Check == 35)
			{
				Console.WriteLine($"possible splits are {Check}/{DoMath.down} or {Check}/{DoMath.left} or {Check}/{DoMath.up} \n");
			}
			else if (Check == 36)
			{
				Console.WriteLine($"possible splits are {Check}/{DoMath.down} or {Check}/{DoMath.left} \n");
			}
		}

		public void Corner()
		{
			int Check = gen.RanNumber;


			foreach (int b in Rows1)
			{
				if (b.Equals(Check))
				{
					Console.WriteLine($"possible corner are {Check}/{DoMath.right}/{DoMath.upright}/{DoMath.up} " +
						                              $" or {Check}/{DoMath.left}/{DoMath.upleft}/{DoMath.up} \n");
				}
			}

			foreach (int b in Rows2)
			{
				if (b.Equals(Check))
				{
					Console.WriteLine($"possible corner are {Check} {DoMath.right}/{DoMath.upright}/{DoMath.up} " +
													  $" or {Check}/{DoMath.left}/{DoMath.upleft}/{DoMath.up}" +
			                                          $" or {Check}/{DoMath.left}/{DoMath.downleft}/{DoMath.down}" +
											          $" or {Check}/{DoMath.down}/{DoMath.downright}/{DoMath.right} \n");
				}
			}

			foreach (int b in Rows3)
			{
				if (b.Equals(Check))
				{
					Console.WriteLine($"possible conrner are {Check}/{DoMath.right}/{DoMath.downright}/{DoMath.down} " +
													  $" or {Check}/{DoMath.left}/{DoMath.downleft}/{DoMath.down} \n");
				}
			}

			if (Check == 1)
			{
				Console.WriteLine($"possible corner are {Check}/{DoMath.right}/{DoMath.upright}/{DoMath.up} \n ");
			}
			else if (Check == 2)
			{
				Console.WriteLine($"possible corner are {Check}/{DoMath.right}/{DoMath.upright}/{DoMath.up} " +
												 $" or {Check}/{DoMath.down}/{DoMath.downright}/{DoMath.right} \n");
			}
			else if (Check == 3)
			{
				Console.WriteLine($"possible conrner are {Check}/{DoMath.right}/{DoMath.downright}/{DoMath.down} \n");
			}
			else if (Check == 34)
			{
				Console.WriteLine($"possible corner are {Check}/{DoMath.left}/{DoMath.upleft}/{DoMath.up} \n");
			}
			else if (Check == 35)
			{
				Console.WriteLine($"possible corner are {Check}/{DoMath.left}/{DoMath.upleft}/{DoMath.up}" +
													  $" or {Check}/{DoMath.left}/{DoMath.downleft}/{DoMath.down} \n");
			}
			else if (Check == 36)
			{
				Console.WriteLine($"possible conrner are {Check}/{DoMath.left}/{DoMath.downleft}/{DoMath.down} \n");
			}
		}
	}
}
