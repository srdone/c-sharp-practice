using System;

public class Summer
{
	int sum = 0;
	int count = 0;
	float average;
	
	public void DoAverage()
	{
		try
		{
			average = sum / count;
		}
		
		catch (DivideByZeroException e)
		{
			//do cleanup
			throw e;
		}
	}
}

class Test
{
	public static void Main()
	{
		Summer summer = new Summer();
		
		try
		{
			summer.DoAverage();
		}
		catch (Exception e)
		{
			Console.WriteLine("Exception {0}", e);
		}
	}
}