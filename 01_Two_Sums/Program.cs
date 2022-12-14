Dictionary<int, int> numbersToFind = new();

int[]? TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if (!numbersToFind.ContainsKey(nums[i]))
        {
            if (!numbersToFind.ContainsKey(target - nums[i]))
                numbersToFind.Add(target - nums[i], i);
            continue;
        }
        return new int[] { numbersToFind[nums[i]], i };
    }
    return null;
}

