// Program to illustrate internal protected access modifier.

using System;

class IllustrateProtected
{
    static void Main( string[] args)
    {
        Person person = new Person();
        person.getNameAndAge();
    }
}

public class Human
{
    internal protected string name = "Ram";
    internal protected int age = 15;
    internal protected string address = "Kathmandu";

    internal protected void getNameAndAge()
    {
        Console.WriteLine($"Name: {name}\n\nAge: {age}\n\nAddress: {address}");
    }
}

public class Person : Human
{
}