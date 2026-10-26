public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length - 1;
        var res = nums[0];

        while (l <= r) {
            if (nums[l] <= nums[r]) {
                res = Math.Min(nums[l], res);
                break;
            }

            var m = (int)((l + r) / 2);

            res = Math.Min(nums[m], res);
            if (nums[m] >= nums[l]) {
                l = m + 1;
            } else {
                r = m - 1;
            }
        }
        return res;
    }
}
