public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var n = piles.Length;

        if (piles.Length > h) {
            return -1;
        }

        // find max
        var max = piles[0];
        for (var i = 1; i < n; i++) {
            max = Math.Max(max, piles[i]);
        }

        var l = 1;
        var r = max;
        var k = max;

        while (l <= r) {
            var m = (l + r) / 2;

            var needHours = 0;
         
            for(var i = 0; i < piles.Length; i++){
                needHours +=  (int)((long)piles[i] + m - 1) / m;
                // 3  
                if(needHours > h){
                    l = m + 1;
                    break;
                }
            }

            if(needHours <= h)
            {
                k  = m;
                r = m - 1;
            }
        }

        return k;
    }
}
