public class Solution {
    public List<List<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<List<int>>();

        var path = new List<int>();

        Array.Sort(candidates);

        void Backtrack(int start, int currentSum) {
            // проверка что сумма равна таргету            
            if(currentSum == target){
                 result.Add(new List<int>(path));
                 return;
            }
           

            for (int i = start; i < candidates.Length; i++) {
                if (currentSum + candidates[i] > target) {
                    return;
                }

                path.Add(candidates[i]);
                Backtrack(i, currentSum + candidates[i]);
                path.RemoveAt(path.Count - 1);  
            }
        }

        Backtrack(0, 0);

        return result; 
    }
}
