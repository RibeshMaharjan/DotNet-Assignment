//Write a Program to demonstrate relational operator overloading in C#.
using System;

class Program
{
    static void Main(string[] args)
    {
        Car toyota = new Car("Corella", 228);
        Car hyundai = new Car("Elantra", 185);

        Console.WriteLine($"Top speed of {toyota.Name} is {toyota.Speed}");
        Console.WriteLine($"Top speed of {hyundai.Name} is {hyundai.Speed}");

        if (toyota > hyundai)
        {
            Console.WriteLine($"\n{toyota.Name} is faster than {hyundai.Name}");
        }
        if (toyota < hyundai)
        {
            Console.WriteLine($"\n{hyundai.Name} is faster than {toyota.Name}");
        }
    }
}
class Car
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public Car(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
    public static bool operator >(Car car1, Car car2)
    {
        return car1.Speed > car2.Speed; 
    }
    public static bool operator <(Car car1, Car car2)
    {
        return car1.Speed < car2.Speed;
    }
}