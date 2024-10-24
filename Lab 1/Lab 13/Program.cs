// Program to Find the longest word in an string array

using System;

class LongestWord
{
    static void Main(string[] args)
    {
        string[] words = { "apple", "banana", "cherry", "watermelon", "kiwi", "orange" };
        Console.WriteLine("String Elements:\n");
        foreach (string word in words)
        {
            Console.Write(word + "\t");
        }
        Console.WriteLine();
        string longestWord = FindLongestWord(words);

        Console.WriteLine($"\nThe Longest word in the Array is {longestWord}.");
    }

    static string FindLongestWord(string[] words)
    {
        string longestWord = "";
        foreach (string word in words)
        {
            if(word.Length > longestWord.Length) longestWord = word;
        }
        return longestWord;
    }
}