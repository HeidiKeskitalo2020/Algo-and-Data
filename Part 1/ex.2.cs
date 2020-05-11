namespace part1
{
  public class Substrings
  {
    public int Calculate(string a, string b)
    {
      int  hits = 0;
      int A = a.Length;
      int B = b.Length;
      // how many times is b in a
      /*
      amountOfHits = 0
      for character == b in a, until a-Lenght - b.Length
        if character == b index 0
          for lenght of b
            if a in next index == b in next index...
              (last if) until b ends
              amountOfHits*/
       
      /* A loop to slide pat[] one by one */
      for (int i = 0; i <= A - B; i++)
      {
        /* For current index i, check for  
        character match */
        int j;
        for (j = 0; j < B; j++)
        {
          if (a[i+j] != b[j])
          {
            break;
          }
        }

        if (j == B)
        {
          hits++;
          j = 0;
        }
      }
        //return the amountOfHits
         return hits;
    }
  }     
}

