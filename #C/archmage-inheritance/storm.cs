// Storm.cs
using System;

namespace MagicalInheritance
{

  class Storm {

     public string Caster
      { get; private set; }
     public bool IsStrong
     { get; private set; }
     public string Essence
     { get; private set; }
      

      public Storm(string caster, bool isStrong, string essence) {
        Caster = caster;
        IsStrong = isStrong;
        Essence = essence;
      }

     public string Announce() {

      if (IsStrong == true) {
        return $"{Caster} cast a strong {Essence} storm!";
      } else {
        return $"{Caster} cast a weak {Essence} storm!";
      }
    }

  }

}