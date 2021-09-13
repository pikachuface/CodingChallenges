using System;
using System.Collections.Generic;

namespace Leetcode_10_medium
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 17, 13, 11, 2, 3, 5, 7 };
            Solution sol = new Solution();
            int[] output = sol.DeckRevealedIncreasing(arr);
            foreach (var card in output)
            {
                Console.WriteLine(card);
            }
        }
    }

    public class Solution
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Queue<int> order = new Queue<int>(deck.Length); 
            Array.Sort(deck);
            order.Enqueue(deck[deck.Length - 1]);
            for (int i = deck.Length - 2; i >= 0; i--)
            {
                if (i > 0)
                {
                    order.Enqueue(deck[i]);
                    order.Enqueue(order.Dequeue());
                }
                else order.Enqueue(deck[i]);
            }
            var output = order.ToArray();
            Array.Reverse(output);
            return output;
        }
    }
}
