using System;

namespace Part3Module5Code2
{
  class Program
  {
    static void Main(string[] args)
    {
      string inputUser;
      bool validInput = false;
      
      Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
      
      do
      {
          inputUser = Console.ReadLine().ToLower().Trim(); //  Administrator -> administrator
          
          if (inputUser == "administrator" || inputUser == "manager" || inputUser == "user")
          {
              validInput = true;
          }
          else
          {
              Console.WriteLine($"The role name that you entered, \"{inputUser}\" is not valid. Enter your role name (Administrator, Manager, or User)");
          }
      
      } while (validInput == false);
      
      Console.WriteLine($"Your input value ({inputUser}) has been accepted.");
    }
  }
}

/*Output
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/
