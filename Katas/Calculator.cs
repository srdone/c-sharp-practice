namespace Katas
{
	public class Calculator
	{
		
		static int addValues(string values)
		{	
			int result = 0;
			foreach (int v in StringParser.parseValues(StringParser.splitNumbers(values)))
			{
				result += v;
			}
			
			return result;
		}
		
		public static int Add(params string[] values)
		{
			int result = 0;
			foreach (string v in values)
			{
				result += addValues(v);
			}
			return result;
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