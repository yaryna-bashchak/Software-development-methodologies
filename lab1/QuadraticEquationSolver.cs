using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuadraticEquationSolver;

public class QuadraticEquationSolver
{
    public QuadraticEquationSolver(float a, float b, float c) 
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private float a { get; set; }
    private float b { get; set; }
    private float c { get; set; }
    private float countOfRoots { get; set; }
    private float? x1 { get; set; }
    private float? x2 { get; set; }

    public void PrintEquation()
    {
        Console.WriteLine($"Equation is: ({a}) x^2 + ({b}) x + ({c}) = 0");
    }

    private void Solve()
    {
        float discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            countOfRoots = 0;
        }
        else if (discriminant == 0)
        {
            countOfRoots = 1;
            x1 = -b / (2 * a);
        }
        else if (discriminant > 0)
        {
            countOfRoots = 2;
            x1 = (-b + (float)Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - (float)Math.Sqrt(discriminant)) / (2 * a);
        }
    }

    public void PrintRoots()
    {
        Solve();
        Console.WriteLine($"There are {countOfRoots} roots");
        if (x1 != null) Console.WriteLine($"x1 = {x1}");
        if (x2 != null) Console.WriteLine($"x2 = {x2}");
    }
}
