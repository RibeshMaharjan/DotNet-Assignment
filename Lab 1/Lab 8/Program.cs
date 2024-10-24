// Program to Print all prime numbers in an interval (i.e. from 5 to 20)

using System;

class PrintPrimeNum
{
    static void Main(string[] args)
    {
        int intervalStart = 5;
        int intervalEnd = 26;

        Console.WriteLine($"Prime Numbers Between {intervalStart} and {intervalEnd}:\n\n");

        for( int i = intervalStart; i <= intervalEnd; i++ )
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }
    
    static bool IsPrime(int num)
    {
        if( num <= 1 ) return false; 
        if( num == 2 ) return true;
        
        for( int i = 2; i <= (num/2); i++ ){
            if( num % i == 0 )
            {
                return false;
            }
        }
        return true;
    }
}