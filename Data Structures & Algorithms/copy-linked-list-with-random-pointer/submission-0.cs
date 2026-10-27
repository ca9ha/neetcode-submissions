/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }

        Dictionary<Node, Node> oldToCopy = new Dictionary<Node, Node>();
        Node cur = head;
        while (cur != null) {
            Node copyNode = new Node(cur.val);
            oldToCopy.Add(cur, copyNode);
            // oldToCopy[cur] = copyNode;
            cur = cur.next;
        }

        cur = head;
        while (cur != null) {
            var node = oldToCopy[cur];

            if (cur.next == null) {
                node.next = null;
            } else {
                node.next = oldToCopy[cur.next];
            }

            if (cur.random == null) {
                node.random = null;
            } else {
                node.random = oldToCopy[cur.random];
            }

            cur = cur.next;
        }

        return oldToCopy[head];
    }
}
