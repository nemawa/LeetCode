public class Solution {
    public void ReverseString(char[] s) {
        char c;
        int l = s.Length;
        for (int i = 0; i < l / 2; i++)    
        {
            c = s[i];
            s[i] = s[l - i - 1];
            s[l - i - 1] = c;
        }
    }
}