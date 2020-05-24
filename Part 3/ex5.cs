using System;
using System.Text;

namespace part3
{
    public class Inversions
    {
        public int[] Create(int n, int k)
        {
            int [] array = new int [n];
            int inversionsCount = 0;
           
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            while(inversionsCount < k)
            {
                if (t[i] > t[])
                inversionsCount++;
            }
            return array;
        }
    }
}
