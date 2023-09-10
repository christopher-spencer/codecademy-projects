using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("*.*.*Welcome to 'True or False?'*.*.*\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = new string[] {"Johnny Carson was a famous astronaut.", "Blueberries are red.", "Hotdogs are awesome.", "Tomorrow is the future.", "Winnebagos are a unique style of Candy Corn."};

      bool[] answers = new bool[] {false, false, true, true, false};

      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length) {
        Console.WriteLine("WARNING!! The number of Questions is not equal to the number of Answers! Please correct the Quiz!!");
      }

      int askingIndex = 0;

      foreach (string question in questions) {

        string input;
        bool isBool = false;
        bool inputBool = false;

        Console.WriteLine("\n");
        Console.Write(question);
        Console.Write(" True or False?");
        

        while (!isBool) {
          Console.WriteLine("\n\n(Please respond with 'True' or 'False').");
          Console.Write("\n>>> ");
          input = Console.ReadLine();
          input = input.ToLower();

          isBool = Boolean.TryParse(input, out inputBool); 
        }

        responses[askingIndex] = inputBool;
        askingIndex++;

      }

      int scoringIndex = 0;
      int score = 0;
      Console.WriteLine("\n");
      
      foreach (bool answer in answers) {
        bool response = responses[scoringIndex];
        scoringIndex++;

        Console.WriteLine($"{scoringIndex}. Input: {response} | Answer: {answer}");

        if (response == answer) {
          score++;
        }
      }

      Console.WriteLine($"\nYou got {score} out of 5 correct!");
      
    }
  }
}