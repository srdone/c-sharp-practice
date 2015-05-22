namespace Katas
{
	public class Calculator
	{
		private int runningResult;
		private readonly IParser parser;
		
		public Calculator(IParser parser)
		{
			runningResult = 0;
			this.parser = parser;
		}
		
		int addValues(string values)
		{	
			int result = 0;
			foreach (int v in parser.Parse(values))
			{
				result += v;
			}
			
			return result;
		}
		
		int subtractValues(string values)
		{
			int result = 0;
			foreach (int v in parser.Parse(values))
			{
				result -= v;
			}
			
			return result;
		}
		
		double divideValues(string values)
		{
			double result = 1;
			foreach (int v in parser.Parse(values))
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
	
	public interface IParser
	{
		int[] Parse(string values);
	}
	
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
	
	class FakeMain
	{
		public static void Main() {}
	}
}