using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm zulrajas = new Storm("Zul'rajas", false, "wind");
      Console.WriteLine(zulrajas.Announce());

      Pupil mezilkree = new Pupil("Mezil-kree");
      Storm pupilStorm = mezilkree.CastWindStorm();
      Console.WriteLine(pupilStorm.Announce());

      Mage guldan = new Mage("Gul'dan");
      Storm mageStorm = guldan.CastRainStorm();
      Console.WriteLine(mageStorm.Announce());

      Archmage nielasAran = new Archmage("Nielas Aran");
      Storm strongRain = nielasAran.CastRainStorm();
      Storm strongLightning = nielasAran.CastLightningStorm();
      Console.WriteLine(strongRain.Announce());
      Console.WriteLine(strongLightning.Announce());
               
    }
  }
}