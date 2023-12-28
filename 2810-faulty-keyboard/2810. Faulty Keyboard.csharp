public class Solution {
    public string FinalString(string s) {
        char[] array = s.ToCharArray();
        List<char> res = new List<char>();

        for (int i = 0; i < array.Length; i++)    
        {
            if (s[i] == 'i')
            {
                res.Reverse();
            }
            else res.Add(s[i]);
        }
        return string.Join("", res.ToArray());
    }
}