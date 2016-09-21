public class Solution {
    public string MinWindow(string s, string t) {
        int min = int.MaxValue;
        List<int> map = new List<int>(128);
        foreach(char c in t) map[c]++;
        int minfront = 0, front = 0, back = 0;
        int len = t.Length;
        while(back < s.Length)
        {
            if(map[s[back]] > 0) 
            {
                map[s[back]]--;
                len--;
                back++;
            }
            while(len == 0)
            {
                if(back - front < min)
                {
                    min = back - front;
                    minfront = front;
                }
                if(++map[s[front]] > 0) len--;
                front++;
            }
        }
        return min == int.MaxValue ? "" : s.Substring(head, min);
    }
}