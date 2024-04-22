using System.Collections;

namespace csharp.problemlibrary.LeetCode.Easy
{
    public class TwoSum
    {
        public static int[] Resolution(int[] nums, int target)
        {
            Hashtable mapped = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (mapped.ContainsKey(complement))
                {
                    return  [(int)mapped[complement], i];
                }
                mapped[nums[i]] = i;
            }
            throw new Exception("Not Found");
        }
    }
}
