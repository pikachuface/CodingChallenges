using System;

namespace csharp
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int index1 = 0;
            int index2 = 0;
            int indexA = 0;
            int[] sortArr = new int[nums1.Length + nums2.Length];
            while (true)
            {
                if (indexA == sortArr.Length)
                {
                    break;
                }
                if (index1 < nums1.Length && index2 < nums2.Length)
                {
                    if (nums1[index1] < nums2[index2])
                        sortArr[indexA++] = nums1[index1++];
                    else
                        sortArr[indexA++] = nums2[index2++];
                }
                else if (index1 < nums1.Length)
                {
                    sortArr[indexA++] = nums1[index1++];
                }
                else
                {
                    sortArr[indexA++] = nums2[index2++];
                }
				Console.WriteLine("Index: "+ (indexA-1)+" Number: " + sortArr[indexA-1]);
            }
			if(sortArr.Length%2 == 1)
			{
				return sortArr[sortArr.Length/2];
			}
			else
            	return ((double)sortArr[sortArr.Length/2-1]+(double)sortArr[sortArr.Length/2])/2;

        }
    }
}
