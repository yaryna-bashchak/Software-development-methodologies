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

  static float[] ReadThreeNumbersFromFile(string fileName)
  {
    float[] numbers = new float[3];

    using (StreamReader reader = new StreamReader(fileName))
    {
      string? line = reader.ReadLine();
      if (!isFileEmpty(line, fileName)) return new float[0];

      string[] splitedLine = (line != null) ? line.Split(' ') : new string[0];
      if (!isFileFormatValid(splitedLine)) return new float[0];

      for (int i = 0; i < splitedLine.Length; i++)
      {
        if (!float.TryParse(splitedLine[i], out numbers[i]))
        {
          Console.WriteLine($"Error. Found invalid value {splitedLine[i]}.");
          return new float[0];
        }
      }
    }

    if (IsAZero(numbers[0])) return new float[0];

    Console.WriteLine($"The three floats are: {numbers[0]}, {numbers[1]}, {numbers[2]}");
    return numbers;
  }

  static bool doesFileExist(string fileName)
  {
    if (!File.Exists(fileName))
    {
      Console.WriteLine($"Error. File {fileName} does not exist");
      return false;
    }

    return true;
  }

  static bool isFileEmpty(string? line, string fileName)
  {
    if (line == null)
    {
      Console.WriteLine($"file {fileName} is empty.");
      return false;
    }

    return true;
  }

  static bool isFileFormatValid(string[] splitedLine)
  {
    if (splitedLine.Length != 3)
    {
      Console.WriteLine("invalid file format");
      return false;
    }

    return true;
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
      if (!doesFileExist(args[0])) return;

      float[] numbers = ReadThreeNumbersFromFile(args[0]);

      if (numbers.Length == 0) return;
      a = numbers[0];
      b = numbers[1];
      c = numbers[2];
    }
  }
}
