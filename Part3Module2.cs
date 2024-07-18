using System;

namespace Part3Module2
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = { 4, 8, 15, 16, 23, 42 };

      bool found = true;
      int total = 0;
      
      foreach (int number in numbers)
      {
          total += number;
      
          if (number == 42)
          {
              if (found)
                  Console.WriteLine("Set contains 42");
          }
      }
      
      Console.WriteLine($"Total: {total}");
          }
  }
}

/*Output
Set contains 42
Total: 108
*/
