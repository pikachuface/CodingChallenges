using System;
using System.Linq;
using System.Collections.Generic;

namespace leetcode_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] candies = {2,3,5,1,3};
            int extraCandies = 3;
            Solution sln = new Solution();
            IList<bool> result = sln.KidsWithCandies(candies, extraCandies);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(candies[i] + " : " + result[i]);
            }
        }
    }
}



public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> result = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
        {
          if(candies[i]+extraCandies>=candies.Max()) result.Add(true);
          else result.Add(false);
        }
        return result;
    }
}
