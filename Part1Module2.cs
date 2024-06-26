using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Bob";
      int messages = 3;
      decimal temperature = 34.4m;

      Console.Write("Hello, ");
      Console.Write(name);
      Console.Write("! You have ");
      Console.Write(messages);
      Console.Write(" messages in your inbox. The temperature is ");
      Console.Write(temperature);
      Console.Write(" celsius.");    
    }
  }
}

//Output
//Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
