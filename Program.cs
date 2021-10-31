using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Tags
{
  class Program
  {
    static Regex findTag = new Regex("<([a-zA-Z]+)>(.+?)</([a-zA-Z]+)>");

    static void Main(string[] args)
    {
      string argsStr = ReadFromFile(args[0]);

      FindTags(argsStr);
    }

    static string ReadFromFile(string path)
    {
      if(string.IsNullOrEmpty(path))
      {
        Console.WriteLine("Please provide a path for a file to read from.");
        Environment.Exit(0);
        return null;
      }
      else
      {
        try
        {
          using(StreamReader sr = new StreamReader(path))
          {
            return sr.ReadToEnd();
          }
        }
        catch
        {
          Console.WriteLine("Please provide a valid path.");
          Environment.Exit(0);
          return null;
        }
      }
    }

    static void FindTags(string args)
    {
      int lastTagIndex = 0;
      foreach (Match potentialTag in findTag.Matches(args))
      {
        if (potentialTag.Groups[1].Value == potentialTag.Groups[3].Value)
        {
          Console.Write(args.Substring(lastTagIndex, potentialTag.Index - lastTagIndex));

          Type t = Type.GetType(AddNamespaceToString(FirstCharToUpper(potentialTag.Groups[1].Value)));
          if(t != null)
          {
            MethodInfo m = t.GetMethod("Apply");
            m.Invoke(null, new string[] { potentialTag.Groups[2].Value });
          }
          else
          {
            Console.Write(potentialTag.Value);
          }
          
          lastTagIndex = potentialTag.Index + potentialTag.Length;
        }
      }

      Console.Write(args.Substring(lastTagIndex));
    }

    static string FirstCharToUpper(string s)
      => s switch
      {
        null => throw new ArgumentNullException(),
        "" => throw new ArgumentException(),
        _ => string.Concat(s[0].ToString().ToUpper(), s.AsSpan(1))
      };

    static string AddNamespaceToString(string input)
      => string.Concat(nameof(Tags), ".", input);
  }
}
