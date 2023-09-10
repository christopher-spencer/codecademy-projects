using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display() {

      if (Hidden == false) {
        Console.WriteLine("Password:");
        Console.WriteLine("--------------");
        Console.WriteLine($"{Password}\n");
      } else if (Hidden == true) {
        Console.WriteLine("Password:");
        Console.WriteLine("--------------");
        Console.WriteLine("*************\n");
      }
    }

    public void Reset() {
      Password = "(Your password has been reset)";
      Hidden = false;
    }
    
  }
}