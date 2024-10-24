//Program to To calculate library fine
using System;
using System.Runtime.ConstrainedExecution;

class CalcLibraryFine
{
    static void Main(string[] args)
    {
        DateTime expectedReturnDate, actualReturnDate;

        Console.WriteLine("Enter the expected return date (yyyy-mm-dd):");
        expectedReturnDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter the actual return date (yyyy-mm-dd):");
        actualReturnDate = DateTime.Parse(Console.ReadLine());

        double fine = CalculateFine(expectedReturnDate, actualReturnDate);

        if ((actualReturnDate - expectedReturnDate).Days > 30)
        {
            Console.WriteLine("\nMembership will be canceled due to the late return.");
        }

        Console.WriteLine($"\nThe fine is: ${fine:F2}");
    }

    static double CalculateFine(DateTime expectedReturnDate, DateTime actualReturnDate)
    {
        int daysLate = (actualReturnDate - expectedReturnDate).Days;

        if (daysLate < 5) return 0;

        if(daysLate < 10) return (daysLate - 5) * 0.5;

        if(daysLate < 30) return (2.5 + ((daysLate - 10) * 1));

        return (2.5 + 20 + ((daysLate - 30) * 1.5));

    }
}