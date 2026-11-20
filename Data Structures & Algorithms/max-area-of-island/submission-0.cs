public class Solution
{
    private readonly HashSet<(int Row, int Col)> visited = new();

    private int rows;
    private int cols;

    public int MaxAreaOfIsland(int[][] grid)
    {
        // Каждый вызов начинает обход с чистого состояния.
        visited.Clear();

        if (grid.Length == 0)
            return 0;

        rows = grid.Length;
        cols = grid[0].Length;

        var maxIsland = 0;

        for (var r = 0; r < rows; r++)
        {
            for (var c = 0; c < cols; c++)
            {
                // Пропускаем воду и ранее обнаруженную сушу.
                // Новую клетку сразу отмечаем посещённой.
                if (grid[r][c] != 1 || !visited.Add((r, c)))
                    continue;

                var sizeOfIsland = TraverseIsland(r, c, grid);

                maxIsland = Math.Max(maxIsland, sizeOfIsland);
            }
        }

        return maxIsland;
    }

    private int TraverseIsland(
        int startRow,
        int startCol,
        int[][] grid)
    {
        var directions = new (int Dr, int Dc)[]
        {
            (1, 0), (-1, 0), (0, 1), (0, -1)
        };

        // Стартовая клетка уже обнаружена и отмечена во внешнем цикле.
        var sizeIsland = 1;

        var queue = new Queue<(int Row, int Col)>();
        queue.Enqueue((startRow, startCol));

        while (queue.Count > 0)
        {
            var (row, col) = queue.Dequeue();

            foreach (var (dr, dc) in directions)
            {
                var nextRow = row + dr;
                var nextCol = col + dc;

                if (nextRow < 0 || nextRow >= rows ||
                    nextCol < 0 || nextCol >= cols)
                {
                    continue;
                }

                if (grid[nextRow][nextCol] == 1 &&
                    visited.Add((nextRow, nextCol)))
                {
                    // Считаем клетку только при первом обнаружении.
                    sizeIsland++;

                    queue.Enqueue((nextRow, nextCol));
                }
            }
        }

        return sizeIsland;
    }
}