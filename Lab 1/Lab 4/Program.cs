// Program to Calculate the Simple Interest 

using System;

class CalcSimpleInterest
{
    static void Main (string[] args)
    {
        int p, t;
        float r;

        Console.WriteLine("Enter the Amount: ");
        p = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Time: ");
        t = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Rate: ");
        r = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("\n\nThe Simple Interest is {0}.", CalSimpleInterest(p, t, r));
    }

    static float CalSimpleInterest(int p, int t, float r)
    {
        float si;

        si = (p * t * r) / 100;
        return si;
    }
}