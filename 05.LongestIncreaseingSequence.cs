using System;

public class LongestIncreaseingSequence
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of integer numbers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        int n = input.Length;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int bestStart = 0;
        int bestLength = 1;
        int start = 0;
        int length = 1;

        Console.Write(numbers[0] + " ");

        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i + 1] > numbers[i])
            {
                length++;

                Console.Write(numbers[i + 1] + " ");

                if (bestLength < length)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            else
            {
                length = 1;
                start = i + 1;

                Console.WriteLine();
                Console.Write(numbers[i + 1] + " ");
            }

        }

        Console.WriteLine();
        Console.Write("Longest: ");

        int count = 0;

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write(numbers[bestStart + count] + " ");
            count++;
        }

        Console.WriteLine();
    }
}
