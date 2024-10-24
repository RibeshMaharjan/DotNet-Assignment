// Program to Find greatest number among 3 numbers using conditional operator

using System;

class FindGreatestNum
{
    static void Main(string[] args)
    {
        int num1 , num2, num3;

        Console.Write("Enter 3 Numbers To Compare: ");

        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nGreatest Number Among {num1}, {num2} & {num3} is: {FindGreatest(num1,num2,num3)}.");
    }

    static int FindGreatest(int num1, int num2, int num3)
    {
        int greatest;

        greatest = num1 > num2 ? num1 : num2;
        greatest = num3 > greatest ? num3 : greatest;

        return greatest;
    }
}