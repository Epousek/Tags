using System;

namespace Tags
{
  class Capitalize
  {
    public static void Apply(string text)
    {
      text = Program.FirstCharToUpper(text);
      Console.Write(text);
    }
  }
}
