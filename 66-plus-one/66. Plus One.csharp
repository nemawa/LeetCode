public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> res = new List<int>();
        int broj =  digits[digits.Length - 1] + 1;
        int prenos = 0;
        if (broj / 10 > 0)
        { 
            prenos = broj / 10;
            broj = broj % 10;
        }
        res.Add(broj);
        for (int i = digits.Length - 2; i >= 0; i--)
        {
            broj = digits[i] + prenos;
            prenos = broj / 10;
            broj = broj % 10;
            res.Add(broj);
        }
        if (prenos > 0) res.Add(prenos);
        res.Reverse();
        return res.ToArray();
    }
}