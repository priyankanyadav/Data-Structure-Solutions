public class Solution {
    public int Reverse(int x) {
        int reverse = 0;
        while(x != 0)
        {
            int result = x%10;  //last digit 
           // reverse = reverse * 10 + result;
            x = x/10;  //remove last digit

            if(reverse > int.MaxValue / 10 || (reverse == int.MaxValue / 10 && result >7))
            return 0;
            if(reverse < int.MinValue / 10 || (reverse == int.MinValue /10 && result < -8))
            return 0;
            reverse = reverse *10 +result;
            }
            return reverse;
        
    }
}
