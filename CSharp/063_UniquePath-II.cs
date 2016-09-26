public class Solution {
    public int UniquePathsWithObstacles(int[,] obstacleGrid) {
        int height = obstacleGrid.GetLength(0);
        int width = obstacleGrid.GetLength(1);
        if(obstacleGrid[height - 1, width - 1] == 1) return 0;
        else obstacleGrid[height - 1, width - 1] = 1;
        for(int i = height - 2; i >= 0; i--)
        {
            if(obstacleGrid[i, width - 1] == 1) obstacleGrid[i, width - 1] = 0;
            else obstacleGrid[i, width - 1] = obstacleGrid[i + 1, width - 1];
        }
        for(int i = width - 2; i >= 0; i--)
        {
            if(obstacleGrid[height - 1, i] == 1) obstacleGrid[height - 1, i] = 0;
            else obstacleGrid[height - 1, i] = obstacleGrid[height - 1, i + 1];
        }
        for(int i = 1; i < Math.Min(height, width); i++)
        {
            for(int j = height - 1 - i; j >= 0; j--)
            {
                if(obstacleGrid[j, width - 1 - i] == 1) obstacleGrid[j, width - 1 - i] = 0;
                else obstacleGrid[j, width - 1 - i] = obstacleGrid[j + 1, width - 1 - i] + obstacleGrid[j, width - i];
            }
            for(int j = width - 1 - i; j >= 0; j--)
            {
                if(obstacleGrid[height - 1 - i, j] == 1) obstacleGrid[height - 1 - i, j] = 0;
                else obstacleGrid[height - 1 - i, j] = obstacleGrid[height - i, j] + obstacleGrid[height - 1 - i, j + 1];
            }
        }
        return obstacleGrid[0, 0];
    }
}