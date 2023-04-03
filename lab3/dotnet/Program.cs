using System;

namespace MyNamespace;
class Program
{
    static void Main(string[] args)
    {
        var person = new Student { FirstName = "Yaryna", LastName = "Bashchak", Group = "IM-11", Age = 19 };
    }
}

class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Group { get; set; }
    public int Age { get; set; }
}
