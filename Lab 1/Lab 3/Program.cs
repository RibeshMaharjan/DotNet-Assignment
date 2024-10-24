// Program to Multiply two Floating Point Numbers Entered by User

using System;

class MulpityNums
{
    static void Main (string[] args)
    {
        double num1, num2;

        Console.WriteLine("Enter Two Numbers to multiply: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n\nThe Product of {0} & {1} is {2}.", num1, num2, MultiplyTwoNum(num1, num2));
    }

    static double MultiplyTwoNum(double num1, double num2)
    {
        double result = num1 * num2;
        return result;
    }
}