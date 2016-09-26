public class Solution {
    public int[] PlusOne(int[] digits) {
        int temp = 1, sum = 0;
        for(int i = digits.Length - 1; i > 0; i--)
        {
            sum = digits[i] + temp;
            digits[i] = sum % 10;
            temp = sum / 10;
        }
        sum = digits[0] + temp;
        if(sum < 10){
            digits[0] = sum;
            return digits;
        }
        else
        {
            int[] res = new int[digits.Length + 1];
            res[0] = 1;
            digits[0] = sum % 10;
            Array.Copy(digits, 0, res, 1, digits.Length);
            return res;
        }
    }
}