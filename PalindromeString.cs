public class Solution {
    public bool IsPalindrome(string s) {
        int left =0;
        int right = s.Length-1;

        while(left < right)
        {
            //skip non-alphanumeric hars
            while(left < right && !Char.IsLetterOrDigit(s[left])) left++;
            while(left < right && !Char.IsLetterOrDigit(s[right])) right --;

            //compare case-insesitively
            if(Char.ToLower(s[left])!= Char.ToLower(s[right]))
            {
              return false;
            }
             left++;
             right--;
        }
        return true;
    }
}
