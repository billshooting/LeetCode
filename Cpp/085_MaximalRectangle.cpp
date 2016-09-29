class Solution{
public:
    int maximalRectangle(vector<vector<char>>& matrix)
    {
        int height = matrix.size();
        if(height == 0) return 0;
        int width = matrix[0].size();
        vector<int> h(width + 1);
        int maxArea = 0, tw = 0, th = 0;
        for(int i = 0; i < height; i++)
        {
            stack<int> stack{};
            for(int j = 0; j < width + 1; j++)
            {
                if(j < width && matrix[i][j] == '1') h[j]++;
                else h[j] = 0;
                if(stack.empty() || h[j] >= h[stack.top()]) stack.push(j);
                else{
                    while(!stack.empty() && h[j] < h[stack.top()])
                    {
                        th = h[stack.top()];
                        stack.pop();
                        tw = stack.empty() ? j : j - 1 - stack.top();
                        maxArea = max(maxArea, th * tw);
                    }
                    stack.push(j);
                }
            }
        }
        return  maxArea;
    }
};