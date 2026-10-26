public class MinStack {
    private Stack<int> stack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();

    public MinStack() {}

    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count > 0) {
            val = Math.Min(val, minStack.Peek());
        }
        minStack.Push(val);
    }

    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
        return minStack.Peek();
    }
}
