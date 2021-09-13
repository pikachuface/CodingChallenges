using System;
using System.Collections.Generic;
using System.Collections;

namespace Leetcode_4
{
    class Program
    {


        static void Main(string[] args)
        {   
            //Input
            int[] arr1 = {28,6,22,8,44,17};
            int[] arr2 = {22,28,8,6};
            Solution sol = new Solution();
            //Output
            int[] result = sol.RelativeSortArray(arr1, arr2);

            Console.Clear();
            Console.Write("Array one: ");
            foreach(var item in arr1)
            {
                Console.Write(item+" ");
            }
            Console.Write("Array two: ");
            foreach(var item in arr2)
            {
                Console.Write(item+" ");
            }
            Console.Write("Result: ");
            foreach(var item in result)
            {
                Console.Write(item+" ");
            }
            
            Console.ReadKey();
        }
    }

    public class Solution {
        public int[] RelativeSortArray(int[] arr1, int[] arr2) 
        {
            List<int>[] tempResult = new List<int>[arr2.Length+1];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i <= arr2.Length; i++)
            {
                if(i<arr2.Length) map.Add(arr2[i], i);
                tempResult[i] = new List<int>();
            }

            foreach(var item in arr1)
            {
                if(map.TryGetValue(item, out int index))
                {
                    tempResult[index].Add(item);
                }
                else tempResult[tempResult.Length-1].Add(item); 
            }

            return GetResult(tempResult);

            int[] GetResult(List<int>[] input)
            {
                input[input.Length-1].Sort();
                List<int> result = new List<int>();
                foreach(var group in input)
                {
                    result.AddRange(group);
                }
                return result.ToArray();
            }
        }
    }
}
