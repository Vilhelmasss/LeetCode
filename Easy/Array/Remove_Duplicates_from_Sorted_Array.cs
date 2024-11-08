// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int duplicateCount = 0;
        List<int> uniquesList = new List<int>();
        uniquesList.Add(nums[0]);

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != uniquesList[uniquesList.Count - 1])
            {
                uniquesList.Add(nums[i]);
            }
        }
        for(int i = 0; i < uniquesList.Count; i++) {
            nums[i] = uniquesList[i];
        }
        return uniquesList.Count;
    }
}