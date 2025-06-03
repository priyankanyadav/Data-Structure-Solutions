public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int cur = nums[i];
            int x = target - cur;
            
            if (map.ContainsKey(x)) {
                return new int[] { map[x], i };
            }

            if (!map.ContainsKey(cur)) {
                map[cur] = i;
            }
        }

        return new int[] {}; 
    }
}
