using System;

namespace FirstQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup
            Solution sol = new Solution();
            //Input
            string input = "LLPPLPPLPLPPLPLPLPPAPPPPPLPALL"; 
            bool result = sol.CheckRecord(input);
            Console.WriteLine(result);
        }
    }

    public class Solution {
        public bool CheckRecord(string s) {
            int L = 0;
            int A = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'A':
                        A++;
                        L=0;
                        if (A>=2) return false;
                        break;
                    case 'L':
                        L++;
                        if (L>=3) return false;
                        break;
                    default:
                        L=0;
                        break;
                }
            }
            return true;
        }
    }
}
