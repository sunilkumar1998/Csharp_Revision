using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Joggers
{
	public class CalculateLaps
	{
		public void NbrOfLaps(int x, int y)
		{
			int temp, lcm;
			temp = (x > y) ? x : y;
			



			while (true)
			{
				if (temp % x == 0 && temp % y == 0) {
					lcm = temp;
					int bdist = lcm / x;
					int charlesdist = lcm / y;
					Console.WriteLine("Bob need to run " + bdist);
					Console.WriteLine("Charles need to run " + charlesdist);
					break;
				}
				temp++;
			}
		}
	}
}
