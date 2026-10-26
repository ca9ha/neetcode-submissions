public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var stack = new Stack<int>();

        stack.Push(0);

        for (var i = 1; i < temperatures.Length; i++) {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                var previous = stack.Pop();

                res[previous] = i - previous;
            }

            stack.Push(i);
        }

        return res;
    }
}
