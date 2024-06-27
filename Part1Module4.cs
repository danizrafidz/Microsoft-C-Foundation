using System;

namespace Part1Module4
{
  class Program
  {
    static void Main(string[] args)
    {
      int fahrenheit = 94;
      decimal celsius = (fahrenheit - 32m) * (5m / 9m);
      Console.WriteLine("The temperature is " + celsius + " Celsius.");
    }
  }
}

/*Output
The temperature is 34.444444444444444444444444447 Celsius.
*/
