public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         var output = new Dictionary<string, List<string>>();            

    foreach (var str in strs) {
        
        int[] countArr = new int[26];

        for (int i = 0; i < str.Length; i++)
        {
            countArr[str[i] - 'a']++;
        }

        var key = string.Join(",", countArr);
        
        if (!output.ContainsKey(key)) {
            output[key] =  new List<string> ();
        }

        output[key].Add(str);
    }

    return output.Values.ToList<List<string>>();
        }
}
