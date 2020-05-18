using System;
namespace part2
{
    public class Changes
    {
        public int Calculate(int[] t)
        {
            int Changes = 0;
            for (int i = 1; i <= t.Length -1; i++)
            {
                if (t[i] == t[i-1]) 
                {
                    if (i < t.Length -1)
                    {
                        Changes++;
                        t[i] = t[i-1] + t[i+1];
                    }    
                    else
                    {
                        t[i] = t[i -1] + t[i];    
                        Changes++;
                    }
                }
            }    
            return Changes; 
        }
    }
}
