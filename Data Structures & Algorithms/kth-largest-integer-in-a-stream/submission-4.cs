public class KthLargest {
    public int K { get; set; }
    public PriorityQueue<int, int> Topk { get; set; }

    public KthLargest(int k, int[] nums) {
        if (k < 1)
            throw new ArgumentOutOfRangeException(nameof(k));

        K = k;

        Topk = new PriorityQueue<int, int>();

        foreach (int number in nums) {
            Topk.Enqueue(number, number);

            if (Topk.Count > k)
                Topk.Dequeue();
        }
    }

    public int Add(int val) {
        if (Topk.TryPeek(out var element, out var priority)) {
            if (Topk.Count < K) {
                Topk.Enqueue(val, val);
            } else {
                // Очередь не пуста, элемент получен в переменной element
                var max = Math.Max(priority, val);

                if (priority < val) {
                    Topk.Dequeue();
                    Topk.Enqueue(max, max);
                }
            }

        } else {
            // Очередь пуста
            Topk.Enqueue(val, val);
        }

        return Topk.Peek();
    }
}
