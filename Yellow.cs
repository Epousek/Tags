﻿using System;

namespace Tags
{
  class Yellow
  {
    public static void Apply(string text)
    {
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.Write(text);
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
