using System;

namespace Tags
{
  static class Uppercase
  {
    public static void Apply(string text)
    {
      text = text.ToUpper();
      Console.Write(text);
    }
  }
}
