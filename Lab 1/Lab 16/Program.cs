// Program to create a class named Bird and display the color of Crow, Pigeon and Penguin.
using System;

namespace BirdClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird crow = new Bird();
            Bird pigeon = new Bird();
            Bird penguin = new Bird();

            crow.name = "Crow";
            crow.color = "Black";
            crow.GetColor();

            pigeon.name = "Pigeon";
            pigeon.color = "Gray";
            pigeon.GetColor();

            penguin.name = "Penguin";
            penguin.color = "Black & White";
            penguin.GetColor();
        }
    }

    class Bird
    {
        public string name;
        public string color;
        public void GetColor()
        {
            Console.WriteLine($"{name} color: {color}\n");
        }
    }
}