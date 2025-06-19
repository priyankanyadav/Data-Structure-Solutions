//Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals
//that cover all the intervals in the input.


public class Solution {
    public int[][] Merge(int[][] intervals) {

        if(intervals == null || intervals.Length == 0 )
        return new int[0][];

        // Sort intervals by their start time
        Array.Sort(intervals,(a,b) =>a[0].CompareTo(b[0]));

        //Initializes a list to hold merged intervals.
        var merged = new List<int[]>();
        merged.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++) {
           // Retrieves the last interval in the merged list (last).
            int[] last = merged[merged.Count - 1];
            //Gets the current interval from the input array at index i.
            int[] current = intervals[i];

            if (current[0] <= last[1]) {
                // Overlap, merge intervals by updating the end time
                last[1] = Math.Max(last[1], current[1]);
            } else {
                // No overlap, add the current interval
                merged.Add(current);
            }
        }
        return merged.ToArray();
    }
}
