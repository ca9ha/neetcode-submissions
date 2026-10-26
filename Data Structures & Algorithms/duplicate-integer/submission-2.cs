public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueArray = new(nums.Length);

        foreach (var item in nums) { 
            var isAdded = uniqueArray.Add(item);
            if (!isAdded)
            {
                return true;
            }
        }
        return false;      
    }
}