public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {

        var s = sentence.Split(' ');
        int res = 0;
        int i = 0;

        foreach (string x in s)
        {
            if (x.StartsWith(searchWord))
            {
                return ++res;
            }

            res++;
        }
        
        return -1;

    }
}