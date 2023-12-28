public class Solution {
    public int TitleToNumber(string columnTitle) {
        int res = 0;
        int pow = 1;
        for (int i = columnTitle.Length - 1; i >= 0; i--)
        {
                res = res + pow * (columnTitle[i] - 'A' +1);
                pow *= 26;
        }

        return res;
    }
}