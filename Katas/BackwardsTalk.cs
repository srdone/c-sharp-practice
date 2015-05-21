namespace Kata
{
	using System;
	
	public class BackwardsTalk
	{
		public static string Revert(string word)
		{
			char[] wordCharArray = word.ToCharArray();
			Array.Reverse(wordCharArray);
			return new string(wordCharArray);
		}
	}
	
	class Run
	{
		public static void Main()
		{
			
		}
	}
}