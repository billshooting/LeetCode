// Iterating a round of Matrix is one loop, use minimun between half of heigth and half of width as loop times;
public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        int height = matrix.GetLength(0), 
            width = matrix.GetLength(1);
        IList<int> res = new List<int>(height * width);
        for(int i = 0; i < Math.Min((height + 1 ) / 2, (width + 1) / 2); i++)
        {
            for(int j = i; j < width - i; j++) res.Add(matrix[i, j]);
            for(int j = i + 1; j < height - i; j++) res.Add(matrix[j, width - i - 1]);
            if(height - 1 - i != i) for(int j = width - i - 2; j >= i; j--) res.Add(matrix[height - 1 - i, j]);
            if(width - i - 1 != i) for(int j = height - i - 2; j >= i + 1; j--) res.Add(matrix[j, i]);
        }
        return res;
    }
}