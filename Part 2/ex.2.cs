using System;

namespace part2
{
    public class LongestRepetition
    {
        public int Calculate(int[] t)
        {
            int repeat = 1;
            int biggest = 1;
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] == t[i - 1]) 
                {
                    repeat++;
                }
                else if (t[i] != t[i -1])
                {
                    repeat = 1;
                }
                if (biggest < repeat)
                {
                    biggest = repeat;
                }
            }
            return biggest;
        }
    }
}

