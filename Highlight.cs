using System;

namespace Tags
{
  static class Highlight
  {
    public static void Apply(string text)
    {
      if (Program.defaultBackgroundColor == ConsoleColor.DarkRed)
        Console.BackgroundColor = ConsoleColor.DarkYellow;
      else
        Console.BackgroundColor = ConsoleColor.DarkRed;

      Console.Write(text);
      Console.BackgroundColor = Program.defaultBackgroundColor;
    }
  }
}
