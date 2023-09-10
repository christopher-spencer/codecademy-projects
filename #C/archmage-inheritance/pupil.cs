// Pupil.cs
using System;

namespace MagicalInheritance
{

  class Pupil {

    public string Title
    { get; private set; }

    public Pupil(string title) {
      Title = title;
    }

    public Storm CastWindStorm() {
      Storm weakWindStorm = new Storm(Title, false, "wind");
      return weakWindStorm;
    }
  }
  
}