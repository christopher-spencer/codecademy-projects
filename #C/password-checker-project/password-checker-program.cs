using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*-_+=";

      int score = 0;

      Console.WriteLine("***Welcome to Password Checker***\n");
      Console.WriteLine("Enter a Password to check its Security Score: >> \n");

      string password = Console.ReadLine();

      if (password.Length >= minLength) {
        score++;
      } 

      if (Tools.Contains(password, uppercase)) {
        score++;
      }

       if (Tools.Contains(password, lowercase)) {
        score++;
      }

       if (Tools.Contains(password, digits)) {
        score++;
      }

       if (Tools.Contains(password, specialChars)) {
        score++;
      }

      Console.WriteLine("\n");
      Console.WriteLine("Your Password Score is: " + score);
      Console.WriteLine("\n");

      switch (score) {
        case 5:
          Console.WriteLine("A score of 5 is extremely strong!");
          break;
        case 4:
          Console.WriteLine("A score of 4 is strong!");
          break;
        case 3: 
          Console.WriteLine("A score of 3 is not bad, but could be improved.");
          break;
        case 2:
          Console.WriteLine("A score of 2 is subpar. We would suggest improving your password!");
          break;
        case 1:
          Console.WriteLine("A score of 1 is a really weak password. We strongly suggest improving this password.");
          break;
        default:
          Console.WriteLine("This password fails to meet any of the Security Standards.");
          break;
      }

    }
  }
}
