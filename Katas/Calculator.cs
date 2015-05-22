namespace Katas
{
	public class Calculator
	{
		private int runningResult;
		
		public Calculator()
		{
			runningResult = 0;
		}
		
		static int addValues(string values)
		{	
			int result = 0;
			foreach (int v in StringParser.parseValues(StringParser.splitNumbers(values)))
			{
				result += v;
			}
			
			return result;
		}
		
		static int subtractValues(string values)
		{
			int result = 0;
			foreach (int v in StringParser.parseValues(StringParser.splitNumbers(values)))
			{
				result -= v;
			}
			
			return result;
		}
		
		static double divideValues(string values)
		{
			double result = 1;
			foreach (int v in StringParser.parseValues(StringParser.splitNumbers(values)))
			{
				result = (result / v);
			}
			
			return result;
		}
		
		public Calculator Add(params string[] values)
		{
			int result = 0;
			foreach (string v in values)
			{
				result += addValues(v);
			}
			runningResult += result;
			
			return this;
		}
		
		public int Equals()
		{
			return runningResult;
		}
		
		public Calculator Reset()
		{
			runningResult = 0;
			
			return this;
		}
		
		public Calculator Subtract(params string[] values)
		{
			int result = 0;
			foreach (string v in values)
			{
				result += subtractValues(v);
			}
			runningResult += result;
			
			return this;
		}
		
		public Calculator Divide(params string[] values)
		{
			double result = 1;
			foreach (string v in values)
			{
				result = (int) (result / divideValues(v));
			}
			runningResult = (int) (runningResult / result);
			
			return this;
		}
	}
	
	public class StringParser
	{
		const string emptyString = "";
		const int emptyStringValue = 0;
		
		public static string[] splitNumbers(string values)
		{
			return values.Split(new char[] {','});
		}
		
		public static int parseSingleValue(string value)
		{
			if (value == emptyString)
			{
				return emptyStringValue;
			}
			else
			{
				return int.Parse(value);
			}
		}
		
		public static int[] parseValues(string[] stringValues)
		{
			int[] parsedValues = new int[stringValues.Length];
			
			for (int i = 0; i < parsedValues.Length; i++)
			{
				parsedValues[i] = parseSingleValue(stringValues[i]);
			}
			
			return parsedValues;
		}
	}
	
	class FakeMain
	{
		public static void Main() {}
	}
}