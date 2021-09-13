using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();
            int[][] costs = {new int[] {10,20}, new int[]{30,200}, new int[]{400,50}, new int[]{30,20}};
            Console.WriteLine(sol.TwoCitySchedCost(costs));
            Console.ReadKey();
        }
    }

    public class Solution {
        public int TwoCitySchedCost(int[][] costs)
        {
            int result = 0;
            person[] people = new person[costs.Length];
            for(int i = 0; i < costs.Length; i++ )
            {
                people[i] = new person(i, costs[i][0] - costs[i][1]);
            }
            people = people.OrderBy(item => item.A).ToArray();
            for(int i = 0; i < costs.Length; i++ )
            {
                if(i<costs.Length/2) result+=costs[people[i].ID][0];
                else result+=costs[people[i].ID][1];
            }
            return result;
        }
    }

    public class person
    {
        public int ID;
        public int A;
        public bool goesA = false;
        
        public person(int _id, int _a)
        {
            this.ID = _id;
            this.A = _a;
        }
    }
}


