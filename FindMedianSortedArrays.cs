using System.Collections.Generic;

namespace leetcode
{
    public partial class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> allNums = new List<int>(nums1);
        allNums.AddRange(nums2);
        allNums.Sort();
        if (allNums.Count % 2 == 1 )
        {
            return allNums[allNums.Count / 2];
        }
        else
        {
            return (allNums[(allNums.Count / 2) - 1] + allNums[allNums.Count / 2]) / 2.0;
        }
    }
}
}