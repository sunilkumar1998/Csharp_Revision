using System;
using System.Collections.Generic;
using System.Text;

namespace products_and_LCMs_Diff
{
	public class CalcDiff
	{
        public  int SumDifferencesBetweenProductsAndLCMs(int[,] pairs)
        {

            int prod = 1, lcm = 0, result = 0;
            for (int i = 0; i < pairs.GetLength(0); i++)
            {
                int num1, num2;
                num1 = pairs[i,0];
                num2 = pairs[i,1];
                prod = (num1 * num2);


                while (num1 != num2)
                {
                    if (num1 > num2)
                    {
                        num1 = num1 - num2;
                    }
                    else
                    {
                        num2 = num2 - num1;
                    }
                }
                if (num1 != 0)
                {
                    lcm = prod / num1;
                }
                else
                    lcm = 0;
                result = result + (prod - lcm);
            }

            return result;
        }

    }
}
