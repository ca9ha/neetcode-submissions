public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        var path = new List<int>();

        void Backtrack(int start) {
            // Любой текущий путь — допустимое подмножество.
            result.Add(new List<int>(path));

            for (int i = start; i < nums.Length; i++) {
                path.Add(nums[i]);  // Выбор

                Backtrack(i + 1);  // Исследование

                path.RemoveAt(path.Count - 1);  // Откат
            }
        }

        Backtrack(0);

        return result;
    }
}
