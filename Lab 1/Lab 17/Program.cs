// Program to Create a parameterized constructor to display the milage of three different models of Car.
using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car modelA = new Car(15.5);
            Car modelB = new Car(20.0);
            Car modelC = new Car(18.7);

            Console.WriteLine($"Model A mileage: {modelA.Mileage} km/l\n");
            Console.WriteLine($"Model B mileage: {modelB.Mileage} km/l\n");
            Console.WriteLine($"Model C mileage: {modelC.Mileage} km/l\n");
        }
    }

    class Car
    {
        public double mileage;

        public Car(double mileage)
        {
            Mileage = mileage;
        }

        public double Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
    }
}