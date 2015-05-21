using System;

class Summer
{
	private double average;
	
	public double Average(int sum, int count)
	{
		try
		{
			average = (int)sum / count;
			return average;
		}
		
		catch (DivideByZeroException e)
		{
			throw (new DivideByZeroException("Count is zero in Average()", e));
		}
	}
}

class MainClass
{
	public static void Main(string[] args)
	{
		Summer summer = new Summer();
		int sum = int.Parse(args[0]);
		int count = int.Parse(args[1]);
		
		try
		{
			double average = summer.Average(sum, count);
			Console.WriteLine("Average is: {0}", average);
		}
		
		catch (DivideByZeroException e)
		{
			Console.WriteLine("You tried to divide by zero, message: {0}", e.Message);
		}
		
		catch (Exception e)
		{
			Console.WriteLine("Another error occurred: {0}", e.Message);
		}
	}
}