using System;
using System.Collections.Generic;
namespace part1
{
  public class LuckyNumbers
  {
    public int Calculate(int a, int b)
    { 
      return CountNumbers(b) - CountNumbers(a - 1);
    }
    private int CountNumbers(int input)
    {
      List<int> list = new List<int>();
      if (input >= 3)
      {
        list.Add(3);
      }
      else
      {
        return 0;
      }
      if (input >= 7)
      {
        list.Add(7);
      }
      else return list.Count;

      int i = 0;
      while (true)
      {
        int next = list[i] * 10 + 3;
        int nextAfterThat = list[i] * 10 + 7;
        if (next > input)
        {
          break;
        }
        list.Add(next);
        if (nextAfterThat > input)
        {
          break;
        }
        list.Add(nextAfterThat);
        i++;
      }
      return list.Count;
    }
  }
}
