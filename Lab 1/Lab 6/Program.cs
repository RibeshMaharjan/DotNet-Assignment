// Program to Count Number of Words in a String

using System;

class CountWord
{
    static void Main (string[] args)
    {
        string sentence;

        Console.WriteLine("Enter the Sentence: ");
        sentence = Console.ReadLine();

        Console.WriteLine ("\n\nNumber of Words in the sectence: {0}.", CountWords(sentence));
    }

    static int CountWords(String sentence)
    {
        String[] words;

        if (String.IsNullOrWhiteSpace(sentence))
        {
            return 0;
        }

        words = sentence.Split(new char[] {' ',',', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);
        
        return words.Length;
    }
}