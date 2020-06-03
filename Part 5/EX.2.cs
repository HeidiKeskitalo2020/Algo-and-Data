using System;
using System.Collections.Generic;

namespace part5
{
    public class Connectivity
    {
        public int n;
        List<int> edges = new List<int>();
        public Connectivity(int n)
        {
            this.n = n;
        }
        public void AddConnection(int a, int b)
        {
            //this.a = beginning;
            //this.b = end;
            edges.Add(a, b);

        }
        public int Calkulate(int x)
        {

            return 0;
        }
    }
}
