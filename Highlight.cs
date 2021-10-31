using System;

namespace Tags
{
  static class Highlight
  {
    public static void Apply(string text)
    {
      Console.BackgroundColor = ConsoleColor.DarkRed;
      Console.Write(text);
      Console.BackgroundColor = ConsoleColor.Black;
    }
  }
}
