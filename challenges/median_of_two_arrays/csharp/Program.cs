using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {};
            int[] nums2 = {1,2,3,4,5};
            Solution sol = new Solution();
            double output = sol.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine("Median: " + output);
        }
    }
}
