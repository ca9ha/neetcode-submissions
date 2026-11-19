public class Solution {
   public int NumIslands(char[][] grid)
{
    if (grid.Length == 0)
        return 0;

    var rows = grid.Length;
    var cols = grid[0].Length;
    var islands = 0;

    var visited = new HashSet<(int Row, int Col)>();
    var directions = new (int Dr, int Dc)[]
    {
        (1, 0), (-1, 0), (0, 1), (0, -1)
    };

    for (var r = 0; r < rows; r++)
    {
        for (var c = 0; c < cols; c++)
        {
            // Если клетка суши уже отмечена, её остров уже посчитан.
            if (grid[r][c] != '1' || !visited.Add((r, c)))
                continue;

            islands++;
            TraverseIsland(r, c);
        }
    }

    return islands;

    void TraverseIsland(int startRow, int startCol)
    {
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
                    continue;

                // Отмечаем клетку до постановки в очередь,
                // чтобы другой сосед не добавил её повторно.
                if (grid[nextRow][nextCol] == '1' &&
                    visited.Add((nextRow, nextCol)))
                {
                    queue.Enqueue((nextRow, nextCol));
                }
            }
        }
    }
}
}
