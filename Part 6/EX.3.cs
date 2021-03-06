using System;
using System.Collections.Generic;

namespace part6
{
    public class Edge1
    {
        public int beginning, end, weight;
        public Edge1 (int beginning, int end, int weight)
        {
            this.beginning = beginning;
            this.end = end;
            this.weight = weight;
        }
    }
   
    public class FloydWarshall
    {
        public int n;
        
        public List <Edge1> edgeList;
        public int[,] adjMatrix;
        public int [,] parent;
        public FloydWarshall(int n)
        {
            this.n = n;
            this.edgeList = new List<Edge1>();
            this.adjMatrix = new int[n + 1, n + 1];
            this.parent = new int [n + 1, n + 1];
            for(int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (i == j)
                    {
                        adjMatrix[i, j] = 0; 
                    }
                    else
                    {
                        adjMatrix[i, j] = int.MaxValue;
                    }
                }
            }
        }    
        public void AddRoad(int a, int b, int d)
        {
            adjMatrix[a, b] = d;
        }

        public int Calculate(int x, int y)
        {
            int [,] distance = new int[n+1, n+1];
            for(int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    distance[i, j] = adjMatrix[i, j];

                    if (adjMatrix[i, j] != int.MaxValue && i != j)
                    {    
                        parent[i, j] = 1;
                    }
                    else
                    {
                        parent[i, j] = -1;
                    }
                }
            }
            
            for (int k = 1; k < n + 1; k++)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    for (int j = 1; j < n + 1; j++)
                    {
                        if (distance[i, k] == int.MaxValue || distance[k, j] == int.MaxValue)
                        {    
                            continue;
                        }    
                        if (distance[i,j] > distance[i, k] + distance[k, j])
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                            parent[i, j] = parent[k, j];
                        }
                    }
                }  
            }
            if (distance[x, y] == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return distance[x, y];
            }
            
        }
    }
}


