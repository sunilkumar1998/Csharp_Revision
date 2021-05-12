using System;

namespace products_and_LCMs_Diff
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the length of array containing pairs:");
			int n = Convert.ToInt32(Console.ReadLine());
			
			int[,] arr = new int[n, 2];
			Console.WriteLine("Enter the array elements:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					arr[i,j]= Convert.ToInt32(Console.ReadLine());
				}
				Console.WriteLine();//new line at each row  
			}

			CalcDiff cacl = new CalcDiff();
			int result=cacl.SumDifferencesBetweenProductsAndLCMs(arr);
			Console.WriteLine("Difference between product and Lcm: \t" + result);
		}
	}
}
