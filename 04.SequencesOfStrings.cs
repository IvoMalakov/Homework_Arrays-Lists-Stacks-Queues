using  System;

public class SequencesOfStrings_4
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < input.Length - 1; i++)
        {
            Console.Write(input[i] + " ");
            if (!input[i].Equals(input[i + 1]))
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine(input[input.Length - 1]);
    }
}
