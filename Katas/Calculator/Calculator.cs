namespace Katas
{
	using System;
	
	enum Operation
	{
		Add, Subtract, Multiply, Divide
	}
	
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
		
		void calculate(int[] values, Operation operation)
		{
			foreach (int v in values)
			{
				switch(operation){
					case Operation.Add:
						runningResult += v;
						break;
					case Operation.Subtract:
						runningResult -= v;
						break;
					case Operation.Divide:
						runningResult = (int) (runningResult / v);
						break;
					default:
						throw new Exception();
				}
			}
		}
		
		public Calculator Add(params string[] values)
		{
			int[] parsedValues = parse(values);
			calculate(parsedValues, Operation.Add);
			return this;
		}
		
		public Calculator Subtract(params string[] values)
		{
			int[] parsedValues = parse(values);
			calculate(parsedValues, Operation.Subtract);
			return this;
		}
		
		public Calculator Divide(params string[] values)
		{
			int[] parsedValues = parse(values);
			calculate(parsedValues, Operation.Divide);
			return this;
		}
		
		public Calculator Reset()
		{
			runningResult = 0;	
			return this;
		}
		
		public int Equals()
		{
			return runningResult;
		}
	}
	
	class FakeMain
	{
		public static void Main() {}
	}
}