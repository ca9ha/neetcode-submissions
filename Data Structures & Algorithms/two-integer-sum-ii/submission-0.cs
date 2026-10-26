public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var l = 0;
        var r = numbers.Length - 1;

        var index = 0;
        while (l <= r) {
            var complement = target - numbers[l];

            if (complement > numbers[r]) {
                l++;
                index = l;
                r = numbers.Length - 1;
            } else if (complement < numbers[r]) {
                r--;
            } else {
                return new int[] { index + 1, r + 1 };
            }
        }

        return [];
    }
}
