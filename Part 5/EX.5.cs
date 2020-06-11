
using System;
using System.Collections.Generic;

namespace part5
{
    public class Labyrinth
    {
        public string Search(char[,] laby)
        {
            int n = laby.GetLength(0);
            int m = laby.GetLength(1);
            int starty = 0;
            int startx = 0;
            int endY = 0;
            int endX = 0;


            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (laby[i, j] == 'a')
                    {
                        starty = i;
                        startx = j;
                    }
                    if (laby[i, j] == 'b')
                    {
                        endY = i;
                        endX = j;
                    }
                }
            }
            bool[,]visited = new bool[n, m];
            Queue<int> queueX = new Queue<int>();
            Queue<int> QueueY = new Queue<int>();
            int[,] previousX = new int[n, m];
            int[,] previousY = new int[n, m];

            previousX[starty, startx] = -1;

            visited[starty, startx] = true;
            QueueY.Enqueue(starty);
            queueX.Enqueue(startx);

            while(queueX.Count != 0)
            {
                int CurrentY = QueueY.Dequeue();
                int CurrentX = queueX.Dequeue();

                int neighborY = CurrentY -1;
                int neighborX = CurrentX;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    //Console.WriteLine("Went up!")
                    visited[neighborY, neighborX] = true;
                    previousY[neighborY, neighborX] = CurrentY;
                    previousX[neighborY, neighborX] = CurrentX;
                    queueX.Enqueue(neighborX);
                    QueueY.Enqueue(neighborY);
                    
                }

                neighborY = CurrentY + 1;

                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    //Console.WriteLine("Went up!")
                    visited[neighborY, neighborX] = true;
                    previousY[neighborY, neighborX] = CurrentY;
                    previousX[neighborY, neighborX] = CurrentX;
                    queueX.Enqueue(neighborX);
                    QueueY.Enqueue(neighborY);
                }

                neighborY = CurrentY;
                neighborX = CurrentX -1;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX] != '#')
                {
                    //Console.WriteLine("Went !")
                    visited[neighborY, neighborX] = true;
                    previousY[neighborY, neighborX] = CurrentY;
                    previousX[neighborY, neighborX] = CurrentX;
                    queueX.Enqueue(neighborX);
                    QueueY.Enqueue(neighborY);

                neighborX = CurrentX +1;
            }
            if (!visited[endY, endX])
            { 
                return "DIDN'T FIND A PATH";
            }
            string description = "";
            int y = endY;
            int x = endX;

            while (previousX[y, x] != -1)
            {
                if (previousY[y, x] == y -1)
                {
                    description = 'D' + description;
                }
                else if (previousY[y, x] == y + 1)
                {
                    description = 'U' + description;
                }
                else if (previousY[y, x] == x -1)
                {
                    description = 'R' + description;
                }
                else
                {
                    description = 'L' + description;

                }
                int swap = y;
                y = previousY[y, x];
                x = previousX[swap, x];
            }
            return description;
        }
    }
}
