using System;
using System.Linq;

namespace Delete_occurrences
{
	class Program
	{

        

        public static bool checkEquality<T>(T[] first, T[] second)
        {
            return Enumerable.SequenceEqual(first, second);
        }
        static void Main(string[] args)
		{

            UserInput u = new UserInput();
            u.GetInput();

           
          
            
        }
	}
}
