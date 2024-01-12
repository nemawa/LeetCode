public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        if (nums[0] != 0) return 0;
        int expected = nums[^1]*(nums[^1]+1)/2;

        int sum = nums.Sum();
        
        if (expected == sum) return nums[^1]+1;

        return expected - sum;

    }
}