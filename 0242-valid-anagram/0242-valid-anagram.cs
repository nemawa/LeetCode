public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        char[] sch = new char[s.Length];
        char[] tch = new char[t.Length];
        
        for (int i = 0; i < s.Length; i++) 
        { 
            sch[i] = s[i]; 
            tch[i] = t[i];
        } 
        Array.Sort(sch);
        Array.Sort(tch);

        
        for (int i = 0; i < s.Length; i++)
        {
            if (sch[i] != tch[i]) return false;
        }
        return true;
    }
}
