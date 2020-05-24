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
            int a = 0;
            int b = (n - 1);
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            while(inversionsCount < k)
            {
                if (t[i] > t[j])
                inversionsCount++;
            }
            return array;
        }
    }
}
