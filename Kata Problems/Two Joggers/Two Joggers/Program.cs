using System;

namespace Two_Joggers
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Enter the distance of Bob's lap (larger than 0)");
			int boblen = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the distance of Charles's lap (larger than 0)");
			int charleslen = Convert.ToInt32(Console.ReadLine());
			CalculateLaps calc = new CalculateLaps();
			calc.NbrOfLaps(boblen, charleslen);
		}
	}
}
