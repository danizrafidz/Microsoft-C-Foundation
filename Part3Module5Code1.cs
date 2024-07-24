using System;

namespace Part3Module5Code1
{
  class Program
  {
    static void Main(string[] args)
    {
      string userInput;
      bool validInput = false;
      int number = 0;
      
      Console.WriteLine("Enter an integer value between 5 and 10");
      
      do
      {
          userInput = Console.ReadLine(); //elephant
          validInput = int.TryParse(userInput, out number);
      
          //Check is it string or int input
          if (validInput) 
          {
              //Check is value between 5 and 10
              if (number <= 5 || number >= 10)
              {
                  Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10.");
                  validInput = false;
              }
          } 
          else
          {
              Console.WriteLine("Sorry, you entered an invalid number, please try again");
          }
          
      } while (validInput == false);
      
      Console.WriteLine($"Your input value ({userInput}) has been accepted.");
    }
  }
}

/*Output
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
*/
