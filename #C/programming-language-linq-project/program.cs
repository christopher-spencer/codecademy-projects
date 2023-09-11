using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

      // foreach(var language in languages) {
      //   Console.WriteLine(language.Prettify());
      // }

      var eachLanguage = languages.Select(language => $"{language.ChiefDeveloper} created {language.Name} in {language.Year}.");

      // foreach(var lang in eachLanguage) {
      //   Console.WriteLine(lang);
      // }

      var cSharp = from language in languages
        where language.Name.Contains("C#")
        select language.Prettify();

      Console.WriteLine("C# Details:");
      Console.WriteLine("____________");
      foreach(var c in cSharp) {
        Console.WriteLine(c);
      }

      Console.WriteLine("\n");

      var microsoft = from language in languages
        where language.ChiefDeveloper.Contains("Microsoft")
        select language;

      Console.WriteLine("Microsoft Languages:");
      Console.WriteLine("____________________");
      foreach(var m in microsoft) {
        Console.WriteLine(m.Name);
      }

      Console.WriteLine("\n");

      var lisp = from language in languages
        where language.Predecessors.Contains("Lisp")
        select language;

      Console.WriteLine("Languages w/ Lisp as a Predecessor:");
      Console.WriteLine("____________________________________");
      foreach(var l in lisp) {
        Console.WriteLine(l.Name);
      }

      Console.WriteLine("\n");
      
      var scripts = from language in languages
        where language.Name.Contains("Script")
        select language.Name;

      Console.WriteLine("Languages w/ \"Script\" in their Names:");
      Console.WriteLine("____________________________________");
      foreach(var script in scripts) {
        Console.WriteLine(script);
      }

      Console.WriteLine("\n");

      var languageCount = languages.Count();
       
      Console.WriteLine($"There are {languageCount} languages in the languages list.");

      Console.WriteLine("\n");

      var from1995To2005 = languages.Where(language => language.Year >= 1995 && language.Year <= 2005).Select(language => $"{language.Name} was invented in {language.Year}.");

      var count95To2005 = from1995To2005.Count();

      Console.WriteLine($"There were {count95To2005} languages launched from 1995 to 2005 (inclusive).");

      // Console.WriteLine("\n");
      // Console.WriteLine("\nLanguages from 1995 to 2005:");
      // Console.WriteLine("____________________________________");

      // // foreach (var languageInfo in from1995To2005) {
      // //   Console.WriteLine(languageInfo);
      // // }

        Console.WriteLine("\n");
        Console.WriteLine("History of All Programming Languages:");
        Console.WriteLine("__________________________________________");

        PrettyPrintAll(languages);
      
    }

      public static void PrettyPrintAll(IEnumerable<Language> languages) {
        foreach(var language in languages) {
          Console.WriteLine(language.Prettify());
        }
      }

  }
}
