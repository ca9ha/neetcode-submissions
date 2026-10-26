public class Solution {
    public bool IsPalindrome(string s) {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;

        while (leftPointer < rightPointer) {
            while (leftPointer < rightPointer && !char.IsLetterOrDigit(s[leftPointer])) {
                leftPointer++;
            }

            while (leftPointer < rightPointer && !char.IsLetterOrDigit(s[rightPointer])) {
                rightPointer--;
            }

            if (char.ToLower(s[leftPointer]) != char.ToLower(s[rightPointer])) {
                return false;
            }

            leftPointer++;
            rightPointer--;
        }

        return true;
    }
}
