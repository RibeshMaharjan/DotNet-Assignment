//Give an example of how Delegates works in C# with an exam
using System;

public delegate void Calculate(int num1, int num2);

class Program
{
    static void Main(string[] args)
    {

        Calculate addition = new Calculate(add);
        Calculate subtraction = new Calculate(sub);
        Calculate multiplication = new Calculate(mul);

        addition(20, 20);
        subtraction(40, 20);
        multiplication(5, 6);
    }
    public static void add(int n1, int n2)
    {
        Console.WriteLine($"{n1} + {n2}: {n1 + n2}");
    }

    public static void sub(int n1, int n2)
    {
        Console.WriteLine($"{n1} - {n2}: {n1 - n2}");
    }

    public static void mul(int n1, int n2)
    {
        Console.WriteLine($"{n1} * {n2}: {n1 * n2}");
    }
}