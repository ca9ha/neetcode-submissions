public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        var charactersInWindow = new HashSet<char>();
        var maxLength = 0;
        var left = 0;

        for (var right = 0; right < s.Length; right++) {
            while (charactersInWindow.Contains(s[right])) {
                charactersInWindow.Remove(s[left]);
                left++;
            }

            charactersInWindow.Add(s[right]);

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
