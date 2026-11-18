public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        int rows = board.Length;
        int cols = board[0].Length;
        var visited = new bool[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (Search(row, col, 0))
                    return true;
            }
        }

        return false;

        bool Search(int row, int col, int index)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
                return false;

            if (visited[row, col] || board[row][col] != word[index])
                return false;

            if (index == word.Length - 1)
                return true;

            visited[row, col] = true;

            bool found = Search(row + 1, col, index + 1)
                      || Search(row - 1, col, index + 1)
                      || Search(row, col + 1, index + 1)
                      || Search(row, col - 1, index + 1);

            visited[row, col] = false;
            return found;
        }
    }
}