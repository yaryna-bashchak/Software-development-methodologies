namespace HelloWorld;

public static class Program
{
  static float GetInputFloat(char name)
  {
    float k;
    Console.Write($"{name} = ");

    if (!float.TryParse(Console.ReadLine(), out k))
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
