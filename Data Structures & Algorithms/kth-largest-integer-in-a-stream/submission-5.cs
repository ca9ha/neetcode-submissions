public class KthLargest {
    private readonly  int _k ;
    private readonly PriorityQueue<int, int> _topk;

    public KthLargest(int k, int[] nums) {
        if (k < 1)
            throw new ArgumentOutOfRangeException(nameof(k));

        _k = k;

        _topk = new PriorityQueue<int, int>();

        foreach (int number in nums) {
            _topk.Enqueue(number, number);

            if (_topk.Count > k)
                _topk.Dequeue();
        }
    }

    public int Add(int val) {
        if (_topk.Count < _k) {
            _topk.Enqueue(val, val);
        } else {
            var priority = _topk.Peek();

            if (priority < val) {
                _topk.Dequeue();
                _topk.Enqueue(val, val);
            }
        }

        return _topk.Peek();
    }
}
