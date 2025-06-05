# Plus One
//You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
//Increment the large integer by one and return the resulting array of digits.
//Example 1:
//Input: digits = [1,2,3]
//Output: [1,2,4]
//Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be [1,2,4].

public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;

        // Traverse from the last digit
        for (int i = n - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits; // No carry, return directly
            }

            // If digit is 9, set to 0 and continue to carry over
            digits[i] = 0;
        }

        // If loop completes, all digits were 9 (e.g. [9,9,9])
        // So, we need a new array with 1 at the beginning
        int[] result = new int[n + 1];
        result[0] = 1; // All other elements are already 0 by default
        return result;
    }
}
