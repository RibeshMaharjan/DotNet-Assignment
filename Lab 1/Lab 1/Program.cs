// Write a C# Program print your name and address

using System;

namespace PrintName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            String address = Console.ReadLine();

            Console.WriteLine("\n\nName: " + name + "\nAddress: " + address);
        }
    }
}