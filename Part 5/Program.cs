using System;
using System.Text;

namespace part5
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX.2
            /*
            Connectivity c = new Connectivity(6);
            c.AddConnection(1,2);
            c.AddConnection(2,3);
            c.AddConnection(1,3);
            c.AddConnection(3,4);
            c.AddConnection(5,6);
            Console.WriteLine(c.Calculate(1)); // 3*/

            //EX.3
            /*
            Components k = new Components(6);
            k.AddConnection(1,2);
            k.AddConnection(2,3);
            k.AddConnection(1,3);
            k.AddConnection(3,4);
            k.AddConnection(5,6);
            Console.WriteLine(k.Calculate()); // 2*/

            //EX.4
            /*
            Communication com = new Communication(6);
            com.AddConnection(1,2);
            com.AddConnection(2,3);
            com.AddConnection(1,3);
            com.AddConnection(3,4);
            com.AddConnection(5,6);
            Console.WriteLine(com.Examine(1,4)); // true
            Console.WriteLine(com.Examine(2,5)); // false
            Console.WriteLine(com.Examine(5,6)); // true*/

            //EX.5
            
            Labyrinth l = new Labyrinth();
            char[,] c = 
            { 
            {'#','#','#','#','#','#','#'},
            {'#','a','#','.','b','.','#'},
            {'#','.','#','.','#','.','#'},
            {'#','.','.','.','.','.','#'},
            {'#','#','#','#','#','#','#'} };
            Console.WriteLine(l.Search(c)); // DDRRUUR*/
        }
    }
}
