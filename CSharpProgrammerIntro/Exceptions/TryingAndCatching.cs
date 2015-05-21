using System;

class Test
{
	static int zero = 0;
	
	static void AFunction()
	{
		Console.WriteLine("Called AFunction()");
		int j = 22 / zero;
		Console.WriteLine("In AFunction()");
	}
	
	public static void Main()
	{
		try
		{
			try
			{
				AFunction();
			}
			
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Caught {0}", e.Message);
				throw new Exception();
			}
			
			catch (Exception e)
			{
				Console.WriteLine("Caught {0}", e.Message);
			}
			
			Console.WriteLine("Program Complete");
		}
		
		catch (Exception e)
			{
				Console.WriteLine("Caught {0}", e.Message);
			}
		
	}
	
}