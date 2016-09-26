public class Solution {
    public int MinPathSum(int[,] grid) {
        int height = grid.GetLength(0);
        int width = grid.GetLength(1);
        int[,] map = new int[height, width];
        map[height - 1, width - 1] = grid[height - 1, width - 1];
        for(int i = height - 2; i >= 0; i--) map[i, width - 1] = grid[i, width - 1] + map[i + 1, width - 1];
        for(int i = width - 2; i >= 0; i--) map[height - 1, i] = grid[height - 1, i] + map[height - 1, i + 1];
        for(int i = 1; i < Math.Min(height, width); i++)
        {
            for(int j = width - 1 - i; j >= 0; j--) 
                map[height - 1 - i, j] = Math.Min(map[height - i, j], map[height - 1 - i, j + 1]) + grid[height - 1 - i, j];
            for(int j = height - 1 - i; j >= 0; j--)
                map[j, width - 1 - i] = Math.Min(map[j + 1, width - 1 - i], map[j, width - i]) + grid[j, width - 1 - i];
        }
        return map[0, 0];
    }
}