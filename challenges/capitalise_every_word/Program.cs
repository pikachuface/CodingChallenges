using System;
namespace rankup_3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Input: ");
			string input = Console.ReadLine();
			string output = JadenCase.ToJadenCase(input);
			Console.WriteLine(output);
        }
    }

	public static class JadenCase
	{
  		public static string ToJadenCase(this string phrase)
  		{
			string[] words = phrase.Split(' ');
			for(int i = 0; i < words.Length; i++){
				words[i] = Char.ToUpper(words[i][0]) + words[i].Substring(1,words[i].Length-1);
			}
    		return String.Join(' ',words);
  		}
	}
}
