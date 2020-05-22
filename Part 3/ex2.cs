using System;
using System.Text;

namespace part3
{
    public class SmallestDifference
    {
        public int Calculate(int[]t)
        {
            int difference = int.MaxValue;
            for (int i = 0; i < t.Length -1; i++)
                {
                    for ( int j = i + 1; j < t.Length; j++)
                    {
                        if (Math.Abs((t[i] - t[j])) < difference)
                        {
                            difference = Math.Abs(t[i] - t[j]);
                        }
                    }
                }
            return difference;
        }
    }
   
}
