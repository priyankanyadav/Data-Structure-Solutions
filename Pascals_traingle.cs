//Given an integer numRows, return the first numRows of Pascal's triangle.

//In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
// Input: numRows = 5
//Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
//Example 2:
//Input: numRows = 1
//Output: [[1]]
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            List<int> row = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    row.Add(1); // first and last element is always 1
                }
                else
                {
                    int val = result[i - 1][j - 1] + result[i - 1][j];
                    row.Add(val); // sum of two values from previous row
                }
            }

            result.Add(row);
        }
        return result;
    }
}
