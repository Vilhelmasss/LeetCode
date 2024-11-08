// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}

public class Solution2
{
    public bool ContainsDuplicate(int[] nums)
    {
        List<int> uniqueValues = new List<int>();
        for (int i = 0; i < nums.Length - 1; i++)
        {
            uniqueValues.Add(nums[i]);
            if (uniqueValues.Contains(nums[i + 1]))
            {
                return true;
            }
        }
        return false;
    }
}

public class Solution3
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!set.Add(nums[i])) return true;
        }

        return false;
    }
}