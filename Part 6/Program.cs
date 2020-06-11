using System;

namespace part6
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX 1.
            /*BellmanFord  s = new BellmanFord(5);
            s.AddRoad(1,2,7);
            s.AddRoad(2,4,2);
            s.AddRoad(1,3,6);
            s.AddRoad(3,4,5);
            s.AddRoad(4,5,3);
            Console.WriteLine(s.Calculate(1,5)); // 12*/

            // EX 2.
            /*Dijkstra  s = new Dijkstra(5);
            s.AddRoad(1,2,7);
            s.AddRoad(2,4,2);
            s.AddRoad(1,3,6);
            s.AddRoad(3,4,5);
            s.AddRoad(4,5,3);
            Console.WriteLine(s.Calculate(1,5)); // 12*/

            // EX 3.
            FloydWarshall  s = new FloydWarshall(5);
            s.AddRoad(1,2,7);
            s.AddRoad(2,4,2);
            s.AddRoad(1,3,6);
            s.AddRoad(3,4,5);
            s.AddRoad(4,5,3);
            Console.WriteLine(s.Calculate(1,5)); // 1

            // EX 4.
        }
    }
}
