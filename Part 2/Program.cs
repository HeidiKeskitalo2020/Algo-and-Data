using System;
using System.Text;
namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 6.
            LongestRepetition p = new LongestRepetition();
            Console.WriteLine(p.Calculate(new int[] {1,2,1,1,2})); // 2
            Console.WriteLine(p.Calculate(new int[] {1,2,3,4,5})); // 1
            Console.WriteLine(p.Calculate(new int[] {1,1,1,1,1})); // 5
            
            //Exercise 5.
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
