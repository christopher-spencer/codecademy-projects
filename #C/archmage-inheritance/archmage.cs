// Archmage.cs
using System;

namespace MagicalInheritance
{

  class Archmage : Mage {
    
    public Archmage(string title) : base(title) {
      
    }

    public override Storm CastRainStorm() {
      Storm strongRainStorm = new Storm(Title, true, "rain");
      return strongRainStorm;
    }

    public Storm CastLightningStorm() {
      Storm strongLightningStorm = new Storm(Title, true, "lightning");
      return strongLightningStorm;
    }
    
  }
 
}