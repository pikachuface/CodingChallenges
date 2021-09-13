using System;

namespace Leetcode_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend = -5;
            int divisor = 1;

            Solution sol = new Solution();
            int result = sol.Divide(dividend, divisor);

            Console.Write(dividend + "/" + divisor + "=" + result);
        }
    }

    public class Solution
    {

        public int Divide(int dividend, int divisor)
        {
            int biggestNumber = (int)Math.Pow(2,31);


            bool negative;
            if(dividend<0&&divisor<0) negative = false;
            else if ((dividend>0&&divisor<0)||(dividend<0&&divisor>0)) negative = true; 
            else negative = false;

            if(dividend<0) dividend*=-1;
            if(divisor<0) divisor*=-1;

            int result = 0;

            while (dividend >= divisor)
            {
                result++;
                dividend-=divisor;
            }

            if((result>biggestNumber-1)||(result<biggestNumber*-1)) return biggestNumber-1;

            if(negative) return result*=-1;
            else return result;
        }
    }

}
