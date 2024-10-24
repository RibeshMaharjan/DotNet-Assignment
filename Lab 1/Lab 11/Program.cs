// Program to Find min and max number in an array

using System;

class FindMinMax
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 5, 7, 2, 8, -1, 4, 10, 12 };
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        (int min, int max) = FindMinMaxNum(numbers);

        Console.WriteLine($"\nMinimum number: {min}");
        Console.WriteLine($"Maximum number: {max}");
    }

    static (int, int) FindMinMaxNum( int[] numbers )
    {
        int min = numbers[0];
        int max = numbers[0];

        for ( int i = 1; i < numbers.Length; i++ )
        {
            if(numbers[i] < min) { min = numbers[i]; }
            
            if (numbers[i] > max) { max = numbers[i]; }
        }
        return (min, max);
    }
}