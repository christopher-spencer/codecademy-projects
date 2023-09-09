using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.WriteLine("*.*.*Welcome to Secret Message Encryptor*.*.*\n");
      Console.Write("Input a Secret Message that you want Encrypted: >> ");
      string inputMessage = Console.ReadLine();
      inputMessage = inputMessage.ToLower();

      char[] secretMessage = inputMessage.ToCharArray();

      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++) {

       char letter = secretMessage[i];

       int newPosition = (Array.IndexOf(alphabet, letter) + 3) % alphabet.Length;

       char encryptedLetter = alphabet[newPosition];

       encryptedMessage[i] = encryptedLetter;

      }

      string encryptedString = String.Join("", encryptedMessage);

      Console.WriteLine("\n");
      Console.WriteLine($"Your Encrypted Message is: {encryptedString}");


      
    }
  }
}