//Program to illustrate multilevel inheritance
using System;

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Mammal : Animal
{
    public void Walk()
    {
        Console.WriteLine("Mammal is walking.");
    }
}

public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.Eat();
        dog.Walk();
        dog.Bark();
    }
}
