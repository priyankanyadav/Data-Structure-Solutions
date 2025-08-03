//Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
//In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
//example1:
//Input: rowIndex = 3
//Output: [1,3,3,1]


using System;
using System.Collections.Generic;

public class Program
{
    public static IList<int> GetRow(int rowIndex)
    {
        var row = new List<int>();  // This will store the required row
        row.Add(1); // The first element is always 1

        // Start building from row 1 up to rowIndex
        for (int i = 1; i <= rowIndex; i++)
        {
            // Add a dummy element to make space for the next row
            row.Add(0); // This allows us to shift values from right to left

            // Update the row in reverse to avoid overwriting values
            for (int j = i; j > 0; j--)
            {
                row[j] = row[j] + row[j - 1];
            }
        }

        return row;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter row index: ");
        int rowIndex = int.Parse(Console.ReadLine());

        var resultRow = GetRow(rowIndex);
        Console.WriteLine("\nRow " + rowIndex + " of Pascal's Triangle:");
        Console.WriteLine("[" + string.Join(",", resultRow) + "]");
    }
}
