public class Solution {
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator) {
        List<string> res = new List<string>();
        foreach( string s in words)
        {
            string[] w = s.Split(separator);
            foreach (string x in w)
            {
                if (x != "")
                    res.Add(x);
            }
        }   
        return res.ToArray();
    }
}