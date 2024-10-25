//Program to illustrate multiple inheritance using interfaces

using System;

public interface CanFly
{
    void Fly();
}

public interface CanSwim
{
    void Swim();
}

public class Duck : CanFly, CanSwim
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Duck duck = new Duck();

        duck.Fly();
        duck.Swim();
    }
}
