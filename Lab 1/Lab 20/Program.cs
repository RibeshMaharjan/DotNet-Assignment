//Program to illustrate working of this keyword.

using System;

public class Car
{
    private string make;
    private string model;
    private int year;

    public Car(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Make: {this.make},\nModel: {this.model},\nYear: {this.year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2020);

        myCar.DisplayDetails();
    }
}