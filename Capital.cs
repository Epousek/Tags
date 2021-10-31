using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tags
{
  static class Capital
  {
    public static void Apply(string text)
    {
      text = text.ToUpper();
      Console.Write(text);
    }
  }
}
