﻿public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] array = new int[] { 0, 0 };
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    array[0] = i;
                    array[1] = j;
                    return array;
                }
            }
        }
        return array;
    }
}