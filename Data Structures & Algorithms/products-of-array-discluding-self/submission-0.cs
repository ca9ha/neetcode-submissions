public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
        var m = 1;
        res[0] = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            m = nums[i-1] * m;
            res[i] = m;
        }

        m = 1;
        for (var i = nums.Length - 1; i > 0; i--)
        {
            m = nums[i] * m;
            res[i - 1] = m * res[i - 1];
        }

        return res;
    }
}
