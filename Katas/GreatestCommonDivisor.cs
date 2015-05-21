namespace Kata
{
	using System;
	
	public class GreatestCommonDivisor
	{
		private static bool IsDivisor(int possibleDivisor, int valueToDivide)
		{
			return (valueToDivide % possibleDivisor) == 0;
		}
		
		public static int Calculate(int value1, int value2)
		{
			int initialValue = Math.Min(value1, value2);
			int divisorToTest = initialValue;
			bool foundValue = false;
			
			while(!foundValue)
			{
				if (IsDivisor(divisorToTest, value1) && IsDivisor(divisorToTest, value2))
				{
					foundValue = true;
				}
				else
				{
					divisorToTest--;
				}
			}
			
			return divisorToTest;
		}
	}
	
	public class Run
	{
		public static void Main()
		{
			
		}
	}
}