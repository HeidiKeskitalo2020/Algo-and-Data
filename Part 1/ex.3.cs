namespace part1
{
  public class Tables
  {
    public int Calculate(int[] t)
    {
      int[] t = t;
       if (t.Length == 1)
       {
         return t.Length;
       }
       else
       {
         int[] newArray = ... int [t.Length -1]
         {
           for each number in t.Length until t.Length -1
           {
             t[int +t[int+1]
             add the sum to the newArray
           }
         }
         return Calculate(newArray);
       }
    }
  }
}