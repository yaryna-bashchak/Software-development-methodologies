namespace validation;

public static class Validation
{
    public static bool IsAZero(float a)
    {
    if (a == 0)
    {
      Console.WriteLine("Error. a cannot be 0");
      return true;
    }

    return false;
    }

    public static bool tryParseFloat(string? input, out float k)
    {
    if (!float.TryParse(input, out k))
    {
      Console.WriteLine($"Error. Expected a valid real number, got {input} instead");
      return false;
    }

    return true;
    }

    public static bool doesFileExist(string fileName)
    {
    if (!File.Exists(fileName))
    {
      Console.WriteLine($"Error. File {fileName} does not exist");
      return false;
    }

    return true;
    }

    public static bool isFileEmpty(string? line, string fileName)
    {
    if (line == null)
    {
      Console.WriteLine($"file {fileName} is empty.");
      return false;
    }

    return true;
    }

    public static bool isFileFormatValid(string[] splitedLine)
    {
    if (splitedLine.Length != 3)
    {
      Console.WriteLine("invalid file format");
      return false;
    }

    return true;
    }
}
