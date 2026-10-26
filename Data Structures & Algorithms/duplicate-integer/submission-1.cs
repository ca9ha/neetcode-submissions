public class Solution {
    public bool hasDuplicate(int[] nums) {
        int lenght = nums.Length;
        HashSet<int> ht = new HashSet<int>();

        for (int i = 0; i < lenght; i++)
        {
            if (ht.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                ht.Add(nums[i]);
            }
        }

        return false;
    }
}
