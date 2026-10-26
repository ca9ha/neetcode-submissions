public class Solution {
    public int CharacterReplacement(string s, int k) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        var frequencies = new int[26];
        var left = 0;
        var maxLength = 0;

        for (var right = 0; right < s.Length; right++) {
            // Добавляем новую букву в окно.
            frequencies[s[right] - 'A']++;

            var maxFrequency = GetMaxFrequency(frequencies);

            // Убираем буквы слева, пока окно требует больше k замен.
            while (right - left + 1 - maxFrequency > k) {
                frequencies[s[left] - 'A']--;
                left++;

                maxFrequency = GetMaxFrequency(frequencies);
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

      private static int GetMaxFrequency(int[] frequencies)
  {
      var maxFrequency = 0;

      foreach (var frequency in frequencies)
      {
          maxFrequency = Math.Max(maxFrequency, frequency);
      }

      return maxFrequency;
  }
}
