class Solution {
    // Function to find the largest element in the array.
    public int largest(List<int> arr) {
        int n = arr.Count;
        int maxNo = arr[0];

        // Iterating through the array to find the maximum element.
        for (int i = 1; i < n; i++) {
            // If current element is greater than the maximum element found so far,
            // update the maximum element.
            if (arr[i] > maxNo) {
                maxNo = arr[i];
            }
        }

        return maxNo;
    }
}
