using System;
using System.Text;
namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 5.
            /*Split s = new Split();
            Console.WriteLine(s.Calculate(new int[] {1,2,-1,4,0})); // 1
            Console.WriteLine(s.Calculate(new int[] {1,2,3,4,5})); // 0
            Console.WriteLine(s.Calculate(new int[] {0,0,0,0,0}));*/ // 4

            // Exercise 4.
            Revolutions r = new Revolutions();
            Console.WriteLine(r.Calculate(new int[] {4,1,3,2,5})); // 3
            Console.WriteLine(r.Calculate(new int[] {1,2,3,4,5})); // 1
            Console.WriteLine(r.Calculate(new int[] {5,4,3,2,1})); // 5

            // Exercise 3.
            /*Changes m = new Changes();
            Console.WriteLine(m.Calculate(new int[] {1,1,2,2,2})); // 2
            Console.WriteLine(m.Calculate(new int[] {1,2,3,4,5})); // 0
            Console.WriteLine(m.Calculate(new int[] {1,1,1,1,1}));*/ // 2
            
            //Exercise 2.
            /*LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] {1,2,1,1,2})); // 2
            Console.WriteLine(p.Calculate(new int[] {1,2,3,4,5})); // 1
            Console.WriteLine(p.Calculate(new int[] {1,1,1,1,1}));*/ // 5
            
            //Exercise 1.
            //Counters compare = new Counters();
            
            //string input10 = compare.CreateInput(10);
            //string input100 = compare.CreateInput(100);
            //string input1000 = compare.CreateInput(1000);
            //string input10000 = compare.CreateInput(10000);
            //string input100000 = compare.CreateInput(100000);

            //compare.CaseI(input100000);
            //compare.CaseII(input100000);

        }
    }
}
