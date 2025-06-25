//Longest Substring Without Repeating Characters.

//Given a string s, find the length of the longest substring without duplicate characters.


public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        //using hashset to store unique character.
        HashSet<char> charSet= new HashSet<char>(); //syntax of hashset

        int left = 0;
        int maxLength = 0;

        for(int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left]);
                left++;
            }
            charSet.Add(s[right]);
            maxLength = Math.Max (maxLength,right - left +1);
        }
        return maxLength;
    }
}
