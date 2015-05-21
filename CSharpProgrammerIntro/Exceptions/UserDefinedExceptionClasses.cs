using System;

public class CountIsZeroException: Exception
{
	public CountIsZeroException() {}
	
	public CountIsZeroException(string message) : base (message) {}
	
	public CountIsZeroException(string message, Exception inner) : base (message, inner) {}
}

public class Summer
{
	int sum = 0;
	int count = 0;
	float average;
	
	public void DoAverage()
	{
		if (count == 0)
		{
			throw (new CountIsZeroException("Zero Count in DoAverage"));
		}
		else
		{
			average = sum / count;
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
		catch (CountIsZeroException e)
		{
			Console.WriteLine("Count is zero exception: {0}", e);
		}
	}
}