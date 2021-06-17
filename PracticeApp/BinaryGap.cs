using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp
{
    public class BinaryGap
    {
        public int FindGap(int num)
        {
            string str = Convert.ToString(num, 2);
            int zeroCount = 0,  maxNum = 0;

            Console.WriteLine(string.Format("{0} equavelent binary is {1}", num, str));
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].ToString() == "0")
                {
                    zeroCount++;
                }
                else if (str[i].ToString() == "1" && zeroCount > 0)
                {
                    if (maxNum < zeroCount) { maxNum = zeroCount; }
                    zeroCount = 0;                    
                }
            }

            return maxNum;
        }

    }
}
