using System;
using System.Text;

namespace part3
{
    public class Sorting
    {
        public void MergeSort(int[] t)
        {
            DateTime start1 = DateTime.Now;
            int a = 0;
            int b = t.Length;
            int k = (a + b)/2;
            int counter1 = 0;

            /*Sorting(a, b);
            if (a == b)
            {
               return;
            }
           
            Sort(a, k)
            sort(k + 1, b)
            merge(a, k, k+1, b)*/
            /*
            merge(a1, b1, ab, b2);
            int a = a1, b = b2;
            for (int i = a; i <=n; i++)
            {
                if (a2 > b2 || (a1<= b1; t[a1] < t[a2]))
                {
                    help[i] = t[a1];
                    a1 += 1;
                }
                else
                {
                    help[i] = t[a2];
                    a2 0= 1;
                }
            }
            for (int i = async < b)
            {
                t[i] = help[i];
            }
            

            DateTime end1 = DateTime.Now;
            Console.WriteLine("Time this took: " + end1.Subtract(start1));
            return counter1;
        }
    
        public void QuickSort(int[] t)
        {
            DateTime start2 = DateTime.Now;
            int counter2 = 0;
            /*sort(a, b)
            sort(a, b)
                if a >= b
                    return
            k = pivot(a,b)
            sort(a, k-1)
            sort(k+1, b)

            pivot(a,b)
                k = a
                for i = a+1 to b
                    if array[i] < array[a]
                        k += 1
                        swap(array[i], array[k])
            swap(array[a], array[k])
            return k

            DateTime end2 = DateTime.Now;
            Console.WriteLine("Time this took: " + end2.Subtract(start2));
            return counter2;
            
        }
    }
}
