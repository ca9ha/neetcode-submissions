public class Solution {
    public int CharacterReplacement(string s, int k) {
     int l = 0;                      // left edge of the window
        int maxcount = 0;               // count of the most frequent letter seen in the window
        int[] count = new int[26];      // letter counts inside the window ('A'..'Z')
        int best = 0;                   // longest valid window so far = the answer

        for (int i = 0; i < s.Length; i++) {             // i = right edge; window grows by one each step
            count[s[i] - 'A']++;                          // s[i] enters the window
            maxcount = Math.Max(maxcount, count[s[i] - 'A']); // new letter may now be the most frequent

            // invalid: letters that aren't the most frequent (= changes needed) exceed k
            while ((i - l + 1) - maxcount > k) {
                count[s[l] - 'A']--;                      // s[l] leaves the window
                l++;
            }

            best = Math.Max(best, i - l + 1);             // window is valid here, so record its length
        }
        return best;
    }
}
