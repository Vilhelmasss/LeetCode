// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/646/

public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] oldNums = new int[nums.Length];
        Array.Copy(nums, oldNums, nums.Length);
        
        for(int i = 0; i < nums.Length; i++) {
            int replacedIndex = (i + k) % nums.Length;
            nums[replacedIndex] = oldNums[i]; 
        }
    }
}