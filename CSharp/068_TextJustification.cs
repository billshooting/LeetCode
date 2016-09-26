// 1. find how many words this line will have;
// 2. calculate the actual Length: words.Length + each ' ' between words.
// 3. use maxWidth - actualLength to determine how many ' ' you should add.
public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        IList<string> res = new List<string>();
        if(words.Length == 0) return res;
        int actualLength = words[0].Length, front = 0, back = 1;
        StringBuilder sb = new StringBuilder();
        for(int i = 1; i < words.Length; i++)
        {
            if(actualLength + 1 + words[i].Length > maxWidth)
            {
                int space = maxWidth - actualLength;
                if(back - front == 1)
                {
                    sb.Append(words[front]);
                    sb.Append(' ', maxWidth - actualLength);
                }
                else
                {
                    int eachSpace = 1 + space / (back - front - 1);
                    int leftExtraSpace = space % (back - front - 1);
                    for(int j = front; j < back; j++)
                    {
                        sb.Append(words[j]);
                        if(j != back - 1)
                        {
                            sb.Append(' ', eachSpace);
                            if(leftExtraSpace != 0)
                            {
                                sb.Append(' ');
                                leftExtraSpace--;
                            }
                        }
                    }
                }
                res.Add(sb.ToString());
                sb.Clear();
                front = back;
                back = back + 1;
                actualLength = words[front].Length;
            }
            else
            {
                actualLength = actualLength + 1 + words[i].Length;
                back++;
            }
        }
        for(int j = front; j < back; j++)
        {
            sb.Append(words[j]);
            if(j != back - 1) sb.Append(' ');
            else sb.Append(' ', maxWidth - actualLength);
        }
        res.Add(sb.ToString());
        return res;
    }
}