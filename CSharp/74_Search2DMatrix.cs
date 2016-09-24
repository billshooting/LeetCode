public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        if(target < matrix[0, 0] || target > matrix[m - 1, n - 1]) return false;
        int front = 0, back = m - 1;
        while(front < back)
        {
            int middle = (front + back + 1) / 2;
            if(matrix[middle, 0] > target) back = middle - 1;
            else if(matrix[middle, 0] == target) return true;
            else front = middle;
        }
        int row = front;
        front = 0;
        back = n - 1;
        while(front < back)
        {
            int middle = (front + back + 1) / 2;
            if(matrix[row, middle] > target) back = middle - 1;
            else if(matrix[row, middle] == target) return true;
            else front = middle;
        }
        if(matrix[row, front] == target) return true;
        return false;
    }
}