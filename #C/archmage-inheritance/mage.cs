// Mage.cs
using System;

namespace MagicalInheritance 
{

  class Mage : Pupil {

    public Mage(string title) : base(title) {
      
    }
    
    public virtual Storm CastRainStorm() {
      Storm weakRainStorm = new Storm(Title, false, "rain");
      return weakRainStorm;
    }

  }
  
}