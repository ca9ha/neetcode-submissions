public class Solution {
    public int MaxArea(int[] heights) {
        var maxArea = 0;

        var l = 0;
        var r = heights.Length - 1;

        while (l < r) {
            var curWudth = r - l;
            var curHeight = heights[l] > heights[r] ? heights[r] : heights[l];
            var curArea = curWudth * curHeight;

            if (curArea > maxArea) {
                maxArea = curArea;
            }
            
            if (heights[l] <= heights[r]) {
                l++;
            } else {
                r--;
            }
        }

        return maxArea;
    }
}
