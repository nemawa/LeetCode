public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> has = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            if (has.Contains(nums[i])) return true;
            has.Add(nums[i]);
        }
        return false;
    }
}