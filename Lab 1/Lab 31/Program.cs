//Write a C# Program to illustrate exception handling

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = Divide(num1, num2);
            Console.WriteLine($"\nResult of {num1} / {num2} = {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("\nError: Division by zero is not allowed.");
        }
        finally
        {
            Console.WriteLine("\nExecution completed.");
        }
    }

    static int Divide(int dividend, int divisor)
    {
        return dividend / divisor;
    }
}
