using System;

namespace Part2Module2
{
  class Program
  {
    static void Main(string[] args)
    {
      int firstValue = 500;
      int secondValue = 600;
      int largerValue;
      largerValue = Math.Max(firstValue, secondValue);
      Console.WriteLine(largerValue);
    }
  }
}

/*Output
600
*/
