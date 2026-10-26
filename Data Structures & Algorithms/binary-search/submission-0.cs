public class Solution {
    public int Search(int[] nums, int target) {
       var left = 0;
        var right = nums.Length - 1;    
        while(left <= right)
        {
            int m = left + ((right - left) / 2);
            if (nums[m] > target) {
                right = m - 1;
            } else if (nums[m] < target) {
                left = m + 1;
            } else {
                return m;
            }         
        }

        return -1; 
    }
}
