using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
