public class Solution {
    public string AddBinary(string a, string b) {
        int temp = 0;
        StringBuilder sb = new StringBuilder();
        for(int i = 1; i <= Math.Max(a.Length, b.Length); i++)
        {
            int cha = 0, chb = 0, sum = 0;
            if(a.Length - i >= 0) cha = a[a.Length - i] - '0';
            if(b.Length - i >= 0) chb = b[b.Length - i] - '0';
            sum = cha + chb + temp;
            sb.Insert(0, sum % 2);
            temp = sum / 2;
        }
        if(temp != 0) sb.Insert(0, temp);
        return sb.ToString();
    }
}