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
Your subscription will expire soon. Renew now!

Your subscription expires in _ days.
Renew now and save 10%!

Your subscription expires within a day!
Renew now and save 20%!

Your subscription has expired.
*/
