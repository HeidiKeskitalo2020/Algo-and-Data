using System;

namespace ExamPrep
{
     public class Counters
    {
        public void Hello(int n)
        {
            if( n == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Hello!");
                Hello(n - 1);
            }
        }
    }
}