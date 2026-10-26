public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var res = new int[temperatures.Length];
        var stack = new Stack<int[]>();

        stack.Push(new int[] { temperatures[0], 0 });

        for (var i = 1; i < temperatures.Length; i++) {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()[1]]) {
                var previous = stack.Pop();

                res[previous[1]] = i - previous[1];
            }

            stack.Push(new[] { temperatures[i], i });
        }

        return res;
    }
}
