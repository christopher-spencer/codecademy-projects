using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("***Welcome to Coin Convertor!***\n");

      Console.WriteLine("-A bronze coin is worth 1 cent. \n");
      Console.WriteLine("-A silver coin is worth 5 cents. \n");
      Console.WriteLine("-A gold coin is worth 10 cents. \n");

      Console.WriteLine("What is the amount of money in cents (less than a dollar) you'd like to convert to bronze, silver and gold? >>\n");
      
      double userAmount = Math.Floor(Convert.ToDouble(Console.ReadLine()));

      Console.WriteLine($"\nLet's get converting! {userAmount} cents is equal to...\n");

      int goldCoinValue = 10;
      int silverCoinValue = 5;
      int bronzeCoinValue = 1;

      double goldCoins = Math.Floor(userAmount / goldCoinValue);

      double leftOver = userAmount % goldCoinValue;

      double silverCoins = Math.Floor(leftOver / silverCoinValue);

      leftOver = leftOver % silverCoinValue;

      double bronzeCoins = leftOver;

      Console.WriteLine("Gold Coins: " + goldCoins);
      Console.WriteLine("Silver Coins: " + silverCoins);
      Console.WriteLine("Bronze Coins: " + bronzeCoins);
      
    }
  }
}