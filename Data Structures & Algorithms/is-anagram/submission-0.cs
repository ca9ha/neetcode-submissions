public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

       var charCount = new Dictionary<char, int>();

        // Подсчитываем символы первой строки
        foreach (char c in s)
        {
            charCount[c] = charCount.GetValueOrDefault(c) + 1;
        }

        // Вычитаем символы второй строки
        foreach (char c in t)
        {
            if (!charCount.ContainsKey(c) || charCount[c] == 0)
                return false;
            charCount[c]--;
        }

        // Проверяем, что все счетчики равны 0
        return charCount.Values.All(count => count == 0);            
    }
}
