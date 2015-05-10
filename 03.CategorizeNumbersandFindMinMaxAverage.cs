using  System;
using System.Collections.Generic;
using  System.Linq;

public class CategorizeNumbersandFindMinMaxAverage
{
    public static void Main()
    {
        Console.WriteLine("Enter your sequence of floating point numbers separated by a space: ");
        string input = Console.ReadLine();

        string[] inputString = input.Split(' ');
        int n = inputString.Length;
        double[] numbers = new double[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(inputString[i]);
        }

        List<int> roundNumbers = new List<int>();
        List<double> floatingNumbers = new List<double>();

        for (int i = 0; i < n; i++)
        {
            int temp;
            bool tryInt = int.TryParse(inputString[i], out temp);

            if ((tryInt) || numbers[i] == (int)numbers[i])
            {
                roundNumbers.Add((int)numbers[i]);
            }

            else
            {
                floatingNumbers.Add(numbers[i]);
            }
        }

        if (floatingNumbers.Count != 0)
        {
            Console.WriteLine();
            Console.WriteLine("Your floating point set look like that: ");
            Console.WriteLine();
            Console.Write("[");

            if (floatingNumbers.Count >= 2)
            {
                for (int i = 0; i < floatingNumbers.Count - 1; i++)
                {
                    Console.Write(floatingNumbers[i] + ", ");
                }

                Console.WriteLine(floatingNumbers[floatingNumbers.Count - 1] + "]");
            }

            else
            {
                Console.WriteLine(floatingNumbers[0] + "]");
            }

            double minFloat = floatingNumbers.Min();
            double maxFloat = floatingNumbers.Max();
            double sumFloat = floatingNumbers.Sum();
            double avergeFloat = floatingNumbers.Average();

            Console.WriteLine("min: {0:F2}, max: {1:F2}, sum: {2:F2}, avg: {3:F2}", minFloat, maxFloat, sumFloat,
                avergeFloat);
        }

        if (roundNumbers.Count != 0)
        {
            Console.WriteLine();
            Console.WriteLine("Your round numbers set look like that: ");
            Console.WriteLine();
            Console.Write("[");

            if (roundNumbers.Count >= 2)
            {
                for (int i = 0; i < roundNumbers.Count - 1; i++)
                {
                    Console.Write(roundNumbers[i] + ", ");
                }

                Console.WriteLine(roundNumbers[roundNumbers.Count - 1] + "]");
            }
            else
            {
                Console.WriteLine(roundNumbers[0] + "]");
            }

            int minInt = roundNumbers.Min();
            int maxInt = roundNumbers.Max();
            int sumInt = roundNumbers.Sum();
            double averageInt = roundNumbers.Average();

            Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:F2}", minInt, maxInt, sumInt, averageInt);
            Console.WriteLine();
        }
    }
}
