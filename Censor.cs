using System;
using System.Text.RegularExpressions;

namespace Tags
{
  class Censor
  {
    public static void Apply(string text)
    {
      text = Regex.Replace(text, @"[a-zA-Z0-9]", "*");
      Console.Write(text);
    }
  }
}
