public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var l = 0;
        var r = 1;

        while (r < prices.Length) {
            if (prices[l] < prices[r]) {
                var profit = prices[r] - prices[l];
                maxProfit = int.Max(maxProfit, profit);
            } else {
                l = r;
            }

            r++;
        }

        return maxProfit;
    }
}
