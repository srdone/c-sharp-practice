namespace Katas
{
	using System;
	
	public class Calculator
	{
		private int runningResult;
		private readonly IParser parser;
		
		public Calculator(IParser parser)
		{
			runningResult = 0;
			this.parser = parser;
		}
		
		int[] parse(string values)
		{
			return parser.Parse(values);
		}
		
		int[] parse(string[] values)
		{
			int[] result = new int[0];
			foreach (string s in values)
			{
				int[] parsedValue = parse(s);
				int[] intermediateResult = new int[parsedValue.Length + result.Length];
				result.CopyTo(intermediateResult, 0);
				parsedValue.CopyTo(intermediateResult, result.Length);
				result = intermediateResult;
			}
			
			return result;
		}
		
		public Calculator Add(params string[] values)
		{
			int[] parsedValues = parse(values);
			foreach (int v in parsedValues)
			{
				runningResult += v;
			}
			
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
			int[] parsedValues = parse(values);
			foreach (int v in parsedValues)
			{
				runningResult -= v;
			}
			
			return this;
		}
		
		public Calculator Divide(params string[] values)
		{
			int[] parsedValues = parse(values);
			foreach (int v in parsedValues)
			{
				runningResult = (int) (runningResult / v);
			}
			
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