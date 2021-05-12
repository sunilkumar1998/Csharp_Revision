using System;
using System.Collections.Generic;
using System.Text;

namespace Delete_occurrences
{
	public static class DeleteNth
	{
        public static int[] DeleteNthOccurence(int[] arr, int N)
        {    // ...
            int[] arr1 = new int[arr.Length];
            int n = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];

                int occurence = 0;
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[j] == temp)
                        occurence++;
                }
                if (occurence < N)
                {
                    arr1[n] = arr[i];
                    n++;
                }


            }

            int[] array = new int[n];
            for (int k = 0; k < array.Length; k++)
                array[k] = arr1[k];
            for (int f = 0; f < array.Length; f++)
                Console.Write("\t "+array[f]);

            return array;


        }
    }
}
