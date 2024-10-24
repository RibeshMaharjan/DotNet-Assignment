// Program to Find the factorial of a number

using System;

class FindFactorial
{
    static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Enter a number to calculate its factorial: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\n\nThe Factorial of {num} is {Factorial(num)}.");
    }

    static int Factorial(int num)
    {
        if (num == 0) return 1;

        if (num == 1) return 1;

        return num * Factorial(num - 1);
    }
}