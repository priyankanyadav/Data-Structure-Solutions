class Solution {
    public int findDuplicate(int[] nums) {
        HashSet<Integer> seen = new HashSet<>();   // 1

        for (int num : nums) {                     // 2
            if (!seen.add(num)) {                  // 3
                return num;                        // 4
            }
        }

        return -1;   
    }
}
