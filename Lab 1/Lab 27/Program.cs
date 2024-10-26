//Write a Program to demonstrate binary operator overloading in C#.

using System;

class Program
{
    static void Main(string[] args)
    {
        Result student1 = new Result("Simon", 52);
        Result student2 = new Result("Harry", 45);

        Console.WriteLine($"{student1.Name} Marks: {student1.Marks}");
        Console.WriteLine($"{student2.Name} Marks: {student2.Marks}");

        Result totalMarks = student1 + student2;
        Console.WriteLine($"\nCombined Marks of the student {totalMarks.Name} is: {totalMarks.Marks}");
    }
}

class Result
{
    public string Name { get; set; }
    public int Marks { get; set; }
    public Result(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }

    public static Result operator +(Result a, Result b)
    {
        return new Result(a.Name + " & " + b.Name, a.Marks + b.Marks);
    }
}