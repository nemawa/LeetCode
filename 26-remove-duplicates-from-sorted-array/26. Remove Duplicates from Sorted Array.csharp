public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int last = 0;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[last])
            {
                nums[last + 1] = nums[i];
                last++;
            }

        }
        return last + 1;
    }
}