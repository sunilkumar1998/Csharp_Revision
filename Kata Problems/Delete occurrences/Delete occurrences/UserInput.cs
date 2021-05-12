using System;
using System.Collections.Generic;
using System.Text;

namespace Delete_occurrences
{
	public class UserInput
	{
		public  void GetInput() {
			Console.WriteLine("Enter the length of Array!");
			int n=Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			Console.WriteLine("Enter the Array you want to perform Operation on!");

			for (int i = 0; i < n; i++) {
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Input : ");
			for (int i = 0; i < n; i++)
			{
				Console.Write("\t"+ arr[i]);
			}
			Console.WriteLine();
			Console.WriteLine("Enter the maximum occurence");
			int N = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			DeleteNth.DeleteNthOccurence(arr, N);
		}
	}
}
