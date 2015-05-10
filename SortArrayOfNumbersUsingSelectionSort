using System;

public class SortArrayOfNumbersUsingSelectionSort
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequnce of numbers separated by a space: ");
        string input = Console.ReadLine();

        string[] inputString = input.Split(' ');
        int n = inputString.Length;
        int[] unsortedArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            unsortedArray[i] = int.Parse(inputString[i]);
        }

        int[] sortedArray = new int[n];
        sortedArray = SelectionSort(unsortedArray);

        Console.WriteLine();
        Console.WriteLine("Your sourted array looks like that: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }

        Console.WriteLine();
    }

    private static int[] SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        return array;
    }
}
