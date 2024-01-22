public class Solution {
    public int FirstUniqChar(string s) {
       HashSet<char> has = new HashSet<char>();
       HashSet<char> has2 = new HashSet<char>();
        
       for (int i = 0; i < s.Length; i++)
       {
           if (has.Contains(s[i]))
           {
               has2.Add(s[i]);
           }
           else
           {
               has.Add(s[i]);
           }
       }
       for (int i = 0; i < s.Length; i++)
       {
           if (!(has2.Contains(s[i]))) return s.IndexOf(s[i]);
       }

       return -1;

       
    }
}