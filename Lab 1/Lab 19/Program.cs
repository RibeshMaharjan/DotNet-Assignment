// Program to automatic Properties
using System;
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Shyam", 30);

        person.DisplayInfo();

        // Attempting to change Name will fail as the setter is private
        person.Age = 31;

        // Displaying the updated person's details
        Console.WriteLine("\n\nDisplaying the updated person's details:\n");
        person.DisplayInfo();
    }
}

public class Person
{
    public string Name { get; private set; }
    public int Age{ get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name},\nAge: {Age}");
    }
}