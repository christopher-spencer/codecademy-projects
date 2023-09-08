using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      BuildACreature("monster", "ghost", "bug");
      BuildACreature("ghost", "bug", "monster");
      BuildACreature("bug", "monster", "ghost");
      RandomMode();
    }

     static void BuildACreature(string head, string body, string feet) {

       int headNum = TranslateToNumber(head);
       int bodyNum = TranslateToNumber(body);
       int feetNum = TranslateToNumber(feet);

       SwitchCase(headNum, bodyNum, feetNum);
        
      }

      static void RandomMode() {

        Random randomNumber = new Random();

       int randomHead = randomNumber.Next(1,4);
       int randomBody = randomNumber.Next(1,4);
       int randomFeet = randomNumber.Next(1,4);

       SwitchCase(randomHead, randomBody, randomFeet);

      }

      static void SwitchCase(int head, int body, int feet) {

        switch (head) {
          case 1:
            GhostHead();
            break;
          case 2:
            BugHead();
            break;
          case 3:
            MonsterHead();
            break;
        }

        switch (body) {
          case 1:
            GhostBody();
            break;
          case 2:
            BugBody();
            break;
          case 3:
            MonsterBody();
            break;
        }

        switch (feet) {
          case 1:
            GhostFeet();
            break;
          case 2:
            BugFeet();
            break;
          case 3:
            MonsterFeet();
            break;
        }

      }

      static int TranslateToNumber(string creature) {

        switch (creature) {
          case "ghost":
            return 1;
          case "bug":
            return 2;
          case "monster":
            return 3;
          default:
            return 1;
        }

      }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}