using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program uses C# to create a Mad Libs word game.
      Author: Christopher Spencer
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Welcome to the Mad Libs Word Game called... \n");

      // Give the Mad Lib a title:
      string title = "***The Dangers of Living Dangerously*** \n";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Choose a Main Character Name: >> \n");
      string mainCharacter = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick an Adjective: >> \n");
      string adj1 = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick another Adjective: >> \n");
      string adj2 = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick one last Adjective: >> \n");
      string adj3 = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Verb: >> \n");
      string verb = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Noun: >> \n");
      string noun1 = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick one more Noun: >> \n");
      string noun2 = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick an animal: >> \n");
      string animal = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Food: >> \n");
      string food = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Fruit: >> \n");
      string fruit = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Superhero: >> \n");
      string superhero = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Country: >> \n");
      string country = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Dessert: >> \n");
      string dessert = Console.ReadLine();
      Console.WriteLine("\n");

      Console.WriteLine("Pick a Year: >> \n");
      string year = Console.ReadLine();
      Console.WriteLine("\n");

      // The template for the story:

      string story = $"This morning {mainCharacter} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {mainCharacter} texted {superhero}, who flew {mainCharacter} to {country} and dropped {mainCharacter} in a puddle of frozen {dessert}. {mainCharacter} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}