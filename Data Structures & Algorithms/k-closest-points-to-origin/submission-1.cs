public class Solution {
    public double GetDistance(int[] x) {
        var xDistance = Math.Sqrt((x[0] * x[0]) + (x[1] * x[1]));
        return xDistance;
    }

    public int[][] KClosest(int[][] points, int k) {
        var heap =
            new PriorityQueue<int[], double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));

        foreach (var point in points) {
            var distance = GetDistance(point);
            heap.Enqueue(point, distance);

            if (heap.Count > k) {
                heap.Dequeue();
            }
        }

        int[][] closestPoints = new int [k][];
        for (var i = 0; i < k; i++) {
            var point = heap.Dequeue();
            closestPoints[i] = point;
        }

        return closestPoints;
    }
}
