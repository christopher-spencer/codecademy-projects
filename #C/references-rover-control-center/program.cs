using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 

      Rover[] rovers = new Rover[] {lunokhod, apollo, sojourner};

      Object[] probes = new Object[] {lunokhod, apollo, sojourner, sputnik};

      IDirectable[] allProbes = new IDirectable[] {lunokhod, apollo, sojourner, sputnik};

  		DirectAll(allProbes);
      TrackAll(probes);


    }

      public static void DirectAll(IDirectable[] allProbes) {

        foreach(IDirectable probe in allProbes) {
          Console.WriteLine(probe.GetInfo());
          Console.WriteLine(probe.Explore());
          Console.WriteLine(probe.Collect());
          Console.WriteLine("\n");
        }
    }

      public static void TrackAll(Object[] probes) {
        
        foreach(Object probe in probes) {
          Object type = probe.GetType();

          Console.WriteLine($"Tracking a {type}...");
          Console.WriteLine("\n");
        }
      }
  }
}