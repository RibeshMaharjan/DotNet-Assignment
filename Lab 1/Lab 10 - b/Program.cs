// Program to To calculate library fine

//If the book is returned on  before  5 days, no fine will be charged.
//If the book is returned after the expected return day (between 5 and 10 days) – fine: 0.5$ per day
//If the book is returned after the expected return day (between 10 and 30 days) fine: 1$ per day
//If the book is not returned after 30 days, cancel membership. fine: 1.5$ per day

using System;
using System.Runtime.ConstrainedExecution;

class CalcLibraryFine
{
    static void Main(string[] args)
    {
        int day;

        Console.WriteLine("Enter the Return Day: ");
        day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your Fine for return day {day} is ${CalcFine(day)}.");

    }

    static double CalcFine(int day)
    {
        double fine, totalFine = 0;

        if (day < 5) return 0;

        if (day > 30)
        {
            //fine: 1.5$ per day
            fine = 1.5;
            totalFine = 0;
            for (int i = 31; i <= day; i++)
            {
                totalFine += fine;
            }
            day = 30;
            Console.WriteLine("Your MemberShip Has been cancel.");
        }
        if (day > 10)
        {
            //fine: 1$ per day
            fine = 1;
            for (int i = 11; i <= day; i++)
            {
                totalFine += fine;
            }
            day = 10;
        }
        if (day > 5)
        {
            //fine: 0.5$ per day
            fine = 0.5;
            for (int i = 6; i <= day; i++)
            {
                totalFine += fine;
            }
            //day = 5;
        }
        return totalFine;
    }
}