using System;
using Bogus;
using Newtonsoft.Json;

namespace MyNamespace;
class Program
{
    static void Main(string[] args)
    {
        var faker = new Faker();
        var rand = new Random();

        var person = new Person {
            FirstName = faker.Name.FirstName(),
            LastName = faker.Name.LastName(),
            Gender = faker.Person.Gender.ToString(),
            Age = rand.Next(100)
        };

        var json = JsonConvert.SerializeObject(person);
        Console.WriteLine(json);
    }
}

class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Gender { get; set; }
    public int Age { get; set; }
}
