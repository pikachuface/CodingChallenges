using System;

namespace rankup_4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Input number: ");
			int input = Int32.Parse(Console.ReadLine());
			Console.WriteLine( Kata.Narcissistic(input));
		}
	}
	public class Kata
	{
  		public static bool Narcissistic(int value)
  		{

			int result = 0;
 			char[] numbers = Convert.ToString(value).ToCharArray();
			for(int i = 0; i < numbers.Length; i++){
				result+= (int)Math.Pow(Char.GetNumericValue(numbers[i]),(double)numbers.Length);
			}
			if(value==(int)result) return true;
			return false;
		}
	}


}
