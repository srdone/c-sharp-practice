namespace Katas
{
	public class StringParser : IParser
	{
		const string emptyString = "";
		const int emptyStringValue = 0;
		
		public StringParser() {}
		
		public int[] Parse(string values)
		{
			return parseValues(splitNumbers(values));
		}
		
		string[] splitNumbers(string values)
		{
			return values.Split(new char[] {','});
		}
		
		int parseSingleValue(string value)
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
		
		int[] parseValues(string[] stringValues)
		{
			int[] parsedValues = new int[stringValues.Length];
			
			for (int i = 0; i < parsedValues.Length; i++)
			{
				parsedValues[i] = parseSingleValue(stringValues[i]);
			}
			
			return parsedValues;
		}
	}
}