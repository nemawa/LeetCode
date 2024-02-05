public class Solution {
    public int MajorityElement(int[] nums) {
        int c = 0;
        int a = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (c == 0) a = nums[i];

            if (nums[i] == a)
                c++;
            else
                c--;
        }
        return a;
    }
}