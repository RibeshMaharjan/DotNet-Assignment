// Program to illustrate static constructors and static class in C#
using System;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Ram", 21);
        Person p2 = new Person("Hari", 25);

        Console.WriteLine($"\nTotal Persons created: {Person.totalPerson}");
    }
}

public class Person
{
    public static int totalPerson;
    public string Name { get; set; }
    public int Age { get; set; }

    static Person()
    {
        totalPerson = 0;
        Console.WriteLine("Static constructor called. Initializing TotalPersons to 0.\n");
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        totalPerson++;
        Console.WriteLine($"Person created: {Name}, Age: {Age}");
    }
}