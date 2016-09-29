public class Solution{
    public int MaximalRectangle(char[,] matrix){
        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);
        if(height == 0 || width == 0) return 0;
        int[] h = new int[width + 1];
        h[width] = 0;
        Stack<int> stack = null;
        int maxArea = 0, temp = 0;
        for(int i = 0; i < height; i++)
        {
            stack = new Stack<int>();
            for(int j = 0; j < width + 1; j++)
            {
                if(j < width && matrix[i, j] == '1') h[j]++;
                else h[j] = 0;
                if(stack.Count == 0 || h[j] >= h[stack.Peek()]) stack.Push(j);
                else
                {
                    while(stack.Count != 0 && h[j] < h[stack.Peek()])
                    {
                        int th = h[stack.Pop()];
                        temp = stack.Count == 0 ? j : j - 1 - stack.Peek();
                        maxArea = Math.Max(maxArea, th * temp);
                    }
                    stack.Push(j);
                }
            }
        }
        return maxArea;
    }
}