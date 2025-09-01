public class Solution {
    public void Rotate(int[] nums, int k) {
      int n = nums.Length;
      k = k%n;
      //reverse thhe whole array
      Reverse(nums,0, n -1);

      //reverse first k element
      Reverse(nums,0,k - 1);

      //reverse the rest
      Reverse (nums,k, n - 1);

    }
     private void Reverse(int[]nums,int left, int right)
     {
      while(left < right)
      {
        int temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;
        left++;
        right--;
      }
     }
}
