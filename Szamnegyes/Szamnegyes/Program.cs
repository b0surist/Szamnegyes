using System;
using System.Linq;

class Program
{
    static int[] CountIncrements(int[,] table)
    {
        int a = table[0, 0] + table[0, 1] + table[1, 0] + table[1, 1];
        int b = table[0, 1] + table[0, 2] + table[1, 1] + table[1, 2];
        int c = table[1, 0] + table[1, 1] + table[2, 0] + table[2, 1];
        int d = table[1, 1] + table[1, 2] + table[2, 1] + table[2, 2];
        
        if (a % 4 != 0 || b % 4 != 0 || c % 4 != 0 || d % 4 != 0)
            return new int[] { -1 };
        
        return new int[] { a / 4, b / 4, c / 4, d / 4 };
    }

    static void Main()
    {
        int[,] table1 = {
            { 1, 2, 1 },
            { 2, 4, 2 },
            { 1, 2, 1 }
        };

        int[,] table2 = {
            { 3, 7, 4 },
            { 5, 16, 11 },
            { 2, 9, 7 }
        };

        Console.WriteLine($"[{string.Join(", ", CountIncrements(table1))}]"); 
        Console.WriteLine($"[{string.Join(", ", CountIncrements(table2))}]"); 
    }
}