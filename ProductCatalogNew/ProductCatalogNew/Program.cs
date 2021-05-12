using ProductProcessing;
using System;

namespace ProductCatalogNew
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("*** WELCOME- HAPPY TO HELP ***");
			Console.WriteLine("Enter Your credentials\n");
			Console.WriteLine("Customer- LoginName: alex pass- 123       Manager- LoginName: erik pass- 789       \n");
			Console.WriteLine("press 1. for Login");
			int choice = Convert.ToInt32(Console.ReadLine());

			MenuManager mobj = new MenuManager(choice);
		}
	}
}
