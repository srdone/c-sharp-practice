using System;

public class NasaCountdownKata : INasaCountdownKata
{
    public int[] Countdown(int start)
    {
				int[] result = new int[(start + 1)];
				int currentValue = start;
        for (int i = 0; i <= start; i++)
				{
					result[i] = currentValue--;
				}
				return result;
    }
}

public interface INasaCountdownKata
{
    /// <summary>
    /// Issue the NASA countdown
    /// </summary>
    /// <param name="start">number to start with</param>
    /// <returns>array with numbers from 'start' to 0</returns>
    int[] Countdown(int start);
}

public class Test
{
	public static void Main(string[] args)
	{
		try
		{
			int startingNumber = int.Parse(args[0]);
			
			INasaCountdownKata kata = new NasaCountdownKata();
			int[] countdownResult = kata.Countdown(startingNumber);
		
			foreach (int i in countdownResult)
			{
				Console.WriteLine(i);
			}
		}
		catch (System.Exception)
		{
			Console.WriteLine("Not an integer, try again");
		}
	}
}