public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var res = new List<List<int>>();
        res.Add(new List<int>(){1});

        for (int i = 1; i < numRows; i++)
        {
            List<int> temp = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                int num;
                if (j == 0 || j == i)
                {
                    num = 1;
                }
                else
                {
                    num = res[i-1][j-1] + res[i-1][j];
                }
                temp.Add(num);
            }
            res.Add(temp);
        }
        return res.ToArray();
       
    }
}