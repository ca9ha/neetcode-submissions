public class Solution {
    public int LastStoneWeight(int[] stones) {
        var heap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach(var stone in stones){
            heap.Enqueue(stone, stone);
        }

        while(heap.Count > 1)
        {
            var y = heap.Dequeue();
            if(heap.Count == 0)
            {
                return y;
            }

            var x = heap.Dequeue();

            if(x != y)
            {                
                heap.Enqueue(y-x, y-x);
            }
        }

       heap.TryPeek(out var lastStone, out var lastPriority);

       return lastStone;        
    }
}
