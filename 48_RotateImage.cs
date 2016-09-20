public class Solution {
    public void Rotate(int[,] matrix) {
        if(matrix.Length == 0 || matrix.Length == 1) return;
        int temp = 0;
        int level = 1;
        int n = (int)Math.Sqrt(matrix.Length);
        while(level <= n/2)
        {
            for(int i= level - 1; i < n - level; i++)
            {
                temp = matrix[i, level - 1];
                int curx = i, cury = level - 1, prex = 0;
                for(int j = 0; j < 3; j++)
                {
                    matrix[curx, cury] = matrix[n - 1 - cury, curx];
                    prex = curx;
                    curx = n - 1 -cury;
                    cury = prex;
                }
                matrix[curx, cury] = temp;
            }
            level++;
        }
    }
}