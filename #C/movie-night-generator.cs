
using System;


namespace SwitchStatement
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("\n");
Console.WriteLine("***Welcome to Movie Night Generator***\n");
Console.WriteLine("Pick a Genre and we will suggest a great film within that Genre for your Movie Night!\n");
Console.WriteLine("The Genres to select from are: \n");
Console.WriteLine("-Drama");
Console.WriteLine("-Comedy");
Console.WriteLine("-Adventure");
Console.WriteLine("-Horror");
Console.WriteLine("-Science Fiction \n");
Console.WriteLine("Which Genre would you like to select?: >>\n");


string genre = Console.ReadLine();
Console.WriteLine("\n");


switch (genre) {
case "Drama":
Console.WriteLine("Citizen Kane");
break;
case "Comedy":
Console.WriteLine("Duck Soup");
break;
case "Adventure":
Console.WriteLine("King Kong");
break;
case "Horror":
Console.WriteLine("Psycho");
break;
case "Science Fiction":
Console.WriteLine("2001: A Space Odyssey");
break;
default:
Console.WriteLine("No movie found");
break;
}


}
}
}


