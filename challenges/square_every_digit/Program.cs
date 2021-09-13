using System;

namespace rankup_6
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Input: ");
			int input = Convert.ToInt32(Console.ReadLine());
			int output = Kata.SquareDigits(input);
			Console.Write($"Output: {output}");
        }
    }
	public class Kata
	{
  		public static int SquareDigits(int n)
  		{
			string output = "";
			char[] nums = Convert.ToString(n).ToCharArray();
			for(int i = 0; i < nums.Length; i++){
				output += Convert.ToString(Math.Pow(Char.GetNumericValue(nums[i]),2));
			}
   		 	return Int32.Parse(output);
  		}
	}

}
