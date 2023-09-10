using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }

    public void Display() {
      Console.WriteLine("\n*.*.*Todo List*.*.*");
      Console.WriteLine("---------------------");
      foreach(string todo in Todos)
      Console.WriteLine($"-{todo}\n");
    }

    public void Reset() {
      for(int i = 0; i < Todos.Length; i++) {
        Todos[i] = "";
      }
      nextOpenIndex = 0;
    }
  }
}