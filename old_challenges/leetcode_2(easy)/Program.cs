using System;
using System.Collections.Generic;

namespace leetcode_2_easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            int[] compression = {1,2,3,4};
            Console.Write("Compression: ");
            foreach(var item in compression) Console.Write(item);
            Console.Write("\nDecompression: "); 
            foreach(var item in sln.DecompressRLElist(compression)) Console.Write(item); 
            Console.ReadKey(true);
        }
    }


    public class Solution 
    {
        public int[] DecompressRLElist(int[] nums) {
            List<int> result = new List<int>();
            for(int i = 0; i < nums.Length; i+=2 )
            {
                for(int y = 0; y < nums[i]; y++) result.Add(nums[i+1]);
            }
            return result.ToArray();
        }
    }

}
