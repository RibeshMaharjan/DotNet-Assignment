// Program to Calculate Area and Perimeter of Circle

using System;
using System.Reflection.Metadata;

class CalcAreaAndPerimeter
{
    static void Main (string[] args)
    {
        const double PI = 3.1415;
        float r;

        Console.WriteLine("Enter the Radius of the Circle: ");
        r = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("\n\nThe Area of the Cirlcle is {0}.", CalArea(r, PI));
        Console.WriteLine("\n\nThe Perimeter of the Cirlcle is {0}.", CalPerimeter(r, PI));
    }

    static double CalArea(float r, double PI)
    {
        double area;

        area = 2 * PI * r;
        return area;
    }

    static double CalPerimeter(float r, double PI)
    {
        double perimeter;

        perimeter = PI * Math.Pow(r, 2);
        return perimeter;
    }
}