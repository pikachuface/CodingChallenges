using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string input = "tree";
            string output = sol.FrequencySort(input);

            Console.WriteLine("Input: " + input);
            Console.WriteLine("output: " + output);
        }
    }

    public class Solution
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!frequency.TryAdd(s[i], 1)) frequency[s[i]]++;
            }
            string result = ""; //would use null but they were expecting: ""

            foreach (KeyValuePair<char, int> character in frequency.OrderByDescending(key => key.Value))
            {
                result += new string(character.Key, character.Value);
            }
            return result;
        }
    }
}
