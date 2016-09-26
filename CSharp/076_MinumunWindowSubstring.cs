public class Solution {
    public string MinWindow(string s, string t) {
        int min = int.MaxValue;
        int[] map = new int[128];
        for(int i = 0; i < map.Length; i++) map[i] = int.MinValue;
        foreach(char c in t) {
            if(map[c] == int.MinValue) map[c] = 1;
            else map[c]++;
        }
        int minFront = 0, front = 0, back = 0;
        int len = t.Length;
        while(back < s.Length)
        {
            if(map[s[back]] != int.MinValue) 
            {
                if(map[s[back]]-- > 0) len--;
                while(len == 0)
                {
                    if(back - front < min)
                    {
                        min = back - front;
                        minFront = front;
                    }
                    if(map[s[front]] != int.MinValue && ++map[s[front]] > 0) len++;
                    front++;
                }
                back++;
            }
            else back++;
        }
        return min == int.MaxValue ? "" : s.Substring(minFront, min + 1);
    }
}