public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length - 1;
        // var min = int.MaxValue;
        var m = l + (r - l) / 2;

        while (l < r) {
            m = l + (r - l) / 2;

            if (nums[m] > nums[r]) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        return nums[l];
    }
}
