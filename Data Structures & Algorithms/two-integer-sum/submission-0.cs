public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    var indicesByValue = new Dictionary<int, int>();

    for (var index = 0; index < nums.Length; index++)
    {
        var current = nums[index];
        var complement = target - current;

        if (indicesByValue.TryGetValue(complement, out var complementIndex))
        {
            return [complementIndex, index];
        }

        indicesByValue[current] = index;
    }

    return [];
    }
}
