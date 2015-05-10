using System;

public class SortArrayOfNummbers
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequnce of numbers separated by a space: ");
        string input = Console.ReadLine();

        string[] inputString = input.Split(' ');
        int n = inputString.Length;
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(inputString[i]);
        }

        Array.Sort(array);

        Console.WriteLine();
        Console.WriteLine("Your sourted array looks like that: ");

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}
