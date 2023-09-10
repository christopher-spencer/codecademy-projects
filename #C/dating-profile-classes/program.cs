using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {

      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

      string[] samHobbies = new string[] { "running", "listening to audiobooks and podcasts", "partying", "playing rec sports like bowling and kickball", "reading advice columns", "writing a speculative fiction novel", "living the dream" };
      
      sam.SetHobbies(samHobbies);

      Console.WriteLine(sam.ViewProfile());
      
    }
  }
}