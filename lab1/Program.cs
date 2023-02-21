using System.Globalization;
using System.Runtime.CompilerServices;

namespace QuadraticEquationSolver;

public static class Program
{
  static float GetInputFloat(char name)
  {
    float k;
    Console.Write($"{name} = ");
    string? input = Console.ReadLine();

    if (!tryParseFloat(input, out k) || (name == 'a' && IsAZero(k))) GetInputFloat(name);

    return k;
  }

  static bool tryParseFloat(string? input, out float k)
  {
    if (!float.TryParse(input, out k))
    {
      Console.WriteLine($"Error. Expected a valid real number, got {input} instead");
      return false;
    }

    return true;
  }

  static bool IsAZero(float a)
  {
    if (a == 0)
    {
      Console.WriteLine("Error. a cannot be 0");
      return true;
    }

    return false;
  }

      {
          Console.WriteLine("Not a valid float. Try again");
          k = GetInputFloat(name);
      }
      else {
          Console.WriteLine($"You set {name} = {k}");
      }
    
    return k;
  }
  static void Main(string[] args)
  {
    CultureInfo culture = new CultureInfo(CultureInfo.CurrentCulture.Name);
    culture.NumberFormat.NumberDecimalSeparator = ".";
    Thread.CurrentThread.CurrentCulture = culture;

    float a, b, c;

    if (args.Length == 0)
    {
      a = GetInputFloat('a');
      b = GetInputFloat('b');
      c = GetInputFloat('c');
    }
    else
    {
      
    }
  }
}
