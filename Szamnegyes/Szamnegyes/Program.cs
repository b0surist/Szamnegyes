using System;

class Program
{
    static int[] CalculateIncrements(int[,] table)
    {
        int[] increments = new int[4];

        increments[0] = (table[0, 0] + table[0, 1] + table[1, 0] + table[1, 1]) / 4;
        increments[1] = (table[0, 1] + table[0, 2] + table[1, 1] + table[1, 2]) / 4;
        increments[2] = (table[1, 0] + table[1, 1] + table[2, 0] + table[2, 1]) / 4;
        increments[3] = (table[1, 1] + table[1, 2] + table[2, 1] + table[2, 2]) / 4;

        return increments;
    }

    static void Main()
    {
        int[,] table =
        {
            {3, 7, 4},
            {5, 16, 11},
            {2, 9, 7}
        };

        int[] result = CalculateIncrements(table);
        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}
