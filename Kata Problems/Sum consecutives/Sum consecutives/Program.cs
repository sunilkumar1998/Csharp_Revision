using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_consecutives
{
	class Program
	{

		public static List<int> SumConsecutives(List<int> s)
		{
			// your code
			List<int> myList = new List<int>();
		
			int a;
			for (int i = 0; i < s.Count; i++)
			{
				a = s[i];
				if (i == s.Count - 1)
				{
					if (s[i] != s[i - 1])
					{
						myList.Add(s[i]);
					}
				}
				for (int j = i + 1; j < s.Count; j++)
				{
					if (s[i] == s[j])
					{
						if (j == s.Count)
						{
							a += s[j];
							myList.Add(a);
						}

						else
						{
							a += s[j];
							i += 1;

						}
					}
					else
					{
						myList.Add(a);
						break;
					}
				}
			}
			return myList;
		}


	
	

		
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			List<int> i = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 };
			List<int> o = new List<int> { 1, 12, 0, 4, 6, 1 };
			Console.WriteLine("Input: {1,4,4,4,0,4,3,3,1}");
			//checkEquality(o, SumConsecutives(i));
			List<int> a = SumConsecutives(i);
			foreach (int j in a)
			{
				Console.WriteLine(j);
			}
		}
	}
}
