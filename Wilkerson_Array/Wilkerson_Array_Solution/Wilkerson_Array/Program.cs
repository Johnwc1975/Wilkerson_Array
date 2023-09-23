using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        int arraySize = 50;
        char[] charArray = GenerateRandomUniqueChars(arraySize);
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        foreach (char c in charArray)
        {
            Console.Write(c + " ");
        }
        stopwatch.Stop();

        Console.WriteLine("\nElapsed Time: " + stopwatch.ElapsedMilliseconds + "ms");
    }

    // Generate an array of random unique characters (case-insensitive)
    static char[] GenerateRandomUniqueChars(int size)
    {
        Random random = new Random();
        string allPossibleChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        // Shuffle the characters randomly
        char[] shuffledChars = allPossibleChars.ToCharArray();
        int n = shuffledChars.Length;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            char temp = shuffledChars[k];
            shuffledChars[k] = shuffledChars[n];
            shuffledChars[n] = temp;
        }

        // Take the first 'size' characters
        return shuffledChars.Take(size).ToArray();
    }
}
