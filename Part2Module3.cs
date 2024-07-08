using System;

namespace Part2Module3
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int daysUntilExpiration = random.Next(12);
      int discountPercentage = 0;
      
      if (daysUntilExpiration == 0)
      {
          Console.WriteLine("Your subscription has expired.");
      }
      else if (daysUntilExpiration == 1)
      {
          Console.WriteLine("Your subscription expires within a day!");
          discountPercentage = 20;
      }
      else if (daysUntilExpiration <= 5)
      {
          Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
          discountPercentage = 10;
      }
      else if (daysUntilExpiration <= 10)
      {
          Console.WriteLine("Your subscription will expire soon. Renew now!");
      }
      
      if (discountPercentage > 0)
      {
          Console.WriteLine($"Renew now and save {discountPercentage}%.");
      }
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
