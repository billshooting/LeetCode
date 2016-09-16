//DFS is work, but when n = 9, it may take a few seconds to recurse and iterte the answer, which is not efficient.
//Actually we dont need to recurse because the sequence is orderby certain order.
//take n = 4 for example, what's the number of sequence that starts with "1"? it's (n - 1)!= 6:
// 1234
// 1243
// 1324
// 1342
// 1423
// 1432
// what's the number of sequence that starts with "12"? it's (n - 2)! = 2;
// So when you find its order, it's a esay problem.

/* Use DFS */
public class Solution {
    public string GetPermutation(int n, int k) {
        bool[] used = new bool[n + 1];
        StringBuilder sb = new StringBuilder();
        int count = 0;
        Permute(sb, n, k, used, 1, ref count);
        return sb.ToString();
    }
    
    private bool Permute(StringBuilder sb, int n, int k, bool[] used, int step, ref int count)
    {
        if(step == n + 1)
        {
            count++;
            if(count == k) return true;
            else return false;
        }
        for(int i = 1; i <= n; i++)
        {
            if(!used[i])
            {
                used[i] = true;
                sb.Append(i);
                if(Permute(sb, n, k, used, step + 1, ref count)) return true;
                sb.Remove(sb.Length - 1, 1);
                used[i] = false;
            }
        }
        return false;
    }
}

/* take advantage of order */
public class Solution {
    public string GetPermutation(int n, int k)
    {
        int[] fac = {1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880};
        if(k > fac[n] || k < fac[0]) return "null";
        bool[] used = new bool[10];
        int cur = k - 1;
        StringBuilder sb = new StringBuilder();
        for(int i = n - 1; i >= 0; i--)
        {
            int temp = cur / fac[i];
            int j = 0;
            for(int p = 0; p <= temp;)
            {
                j++;
                if(used[j] == false) p++;
            }
            sb.Append(j);
            used[j] = true;
            cur = cur % fac[i];
        }
        return sb.ToString();
    }
}

