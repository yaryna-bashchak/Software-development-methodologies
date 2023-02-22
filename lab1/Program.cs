using System.Globalization;
using validation;

namespace QuadraticEquationSolver;

public static class Program
{
  static float GetInputFloat(char name)
  {
    float k;
    Console.Write($"{name} = ");
    string? input = Console.ReadLine();

    if (!Validation.tryParseFloat(input, out k) || (name == 'a' && Validation.IsAZero(k))) k = GetInputFloat(name);

    return k;
  }

  static float[] ReadThreeNumbersFromFile(string fileName)
  {
    float[] numbers = new float[3];

    using (StreamReader reader = new StreamReader(fileName))
    {
      string? line = reader.ReadLine();
      if (!Validation.isFileEmpty(line, fileName)) return new float[0];

      string[] splitedLine = (line != null) ? line.Split(' ') : new string[0];
      if (!Validation.isFileFormatValid(splitedLine)) return new float[0];

      for (int i = 0; i < splitedLine.Length; i++)
      {
        if (!float.TryParse(splitedLine[i], out numbers[i]))
        {
          Console.WriteLine($"Error. Found invalid value {splitedLine[i]}.");
          return new float[0];
        }
      }
    }

    if (Validation.IsAZero(numbers[0])) return new float[0];

    return numbers;
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
      if (!Validation.doesFileExist(args[0])) return;

      float[] numbers = ReadThreeNumbersFromFile(args[0]);
      if (numbers.Length == 0) return;

      a = numbers[0];
      b = numbers[1];
      c = numbers[2];
    }

    QuadraticEquationSolver equation = new QuadraticEquationSolver(a, b, c);
    equation.PrintEquation();
    equation.PrintRoots();
  }
}
