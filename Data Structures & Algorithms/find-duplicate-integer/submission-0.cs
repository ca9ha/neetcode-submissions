public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> unRepeatedNumbers = new HashSet<int>();

        foreach(var num in nums){
            if(unRepeatedNumbers.Contains(num)){
                return num;
            }
            unRepeatedNumbers.Add(num);
        }

        return -1;
    }
}
