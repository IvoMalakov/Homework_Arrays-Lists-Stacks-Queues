using  System;
using  System.Collections.Generic;
using  System.Linq;

public class SubsetSums
{
    public static void Main()
    {
        Console.Write("Enter your number \"N\": ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a sequence of integer numbers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        int length = input.Length;
        int[] numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        double combinations = Math.Pow(2, length);
        bool matchCheck = false;
        List<int> forPrint = new List<int>();

        Console.WriteLine();
        Console.WriteLine("All possible subsets are: ");


        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;

            for (int j = 0; j < length; j++)
            {
                int mask = i & (1 << j);

                if (mask != 0)
                {
                    sum += numbers[length - 1 - j];
                    forPrint.Add(numbers[length - 1 - j]);
                }
            }

            if (sum == n)
            {
                Print(forPrint, sum);
                matchCheck = true;
            }

            forPrint.Clear();
        }

        if (matchCheck == false)
        {
            Console.WriteLine();
            Console.WriteLine("No matching subsets.");
        }
    }

    private static void Print(List<int> nums, int sum)
    {
        Console.WriteLine();
        Console.Write(string.Join(" + ", nums));
        Console.WriteLine(" = " + sum);
    }
}
