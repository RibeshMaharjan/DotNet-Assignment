// Program to Print an Integer Entered by User

using System;

class PrintInteger
{
    static void Main (String[] args)
    {
        Console.WriteLine("Enter the Integer you want to print: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\nUser Input: " + userInput);
    }
}
