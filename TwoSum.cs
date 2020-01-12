using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    public partial class Solution {
        public int[] TwoSum(int[] nums, int target) {
            var lookup = new Dictionary<int, int>();
            for (int l = 0; l < nums.Length; l++)
            {
                lookup.Add(l, nums[l]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (lookup.ContainsValue(target - nums[i]) && lookup.First(c => c.Value == target - nums[i]).Key != i)
                        return new int[] {i, lookup.First(v => v.Value == target - nums[i]).Key};                                 
            }

            return new int[] {0,0};
        }
    }
}