using System;

namespace Part3Module5
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int attackPower = random.Next(1, 11);
      
      int heroHealth = 10;
      int monsterHealth = 10;
      
      //Hero attack
      while (heroHealth > 0)
      {
          attackPower = random.Next(1, 11);
          monsterHealth -= attackPower;
      
          Console.WriteLine($"Monster was damaged and lost {attackPower} health and now has {monsterHealth} health.");
      
          if (monsterHealth <= 0) break;
      
          attackPower = random.Next(1, 11);
          heroHealth -= attackPower;
          Console.WriteLine($"Hero was damaged and lost {attackPower} health and now has {heroHealth} health.");
      }
      
      if (monsterHealth <= 0)
          Console.WriteLine($"Hero wins!");
      else if (heroHealth <= 0)
          Console.WriteLine($"Monster wins!");
    }
  }
}

/*Output
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/
