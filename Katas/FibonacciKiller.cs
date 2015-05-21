using System;

public class FibonacciKillerKata : IFibonacciKillerKata
{
    public int Fibonacci(int n)
    {
        if (n == 0)
				{
					return 0;
				}
				else if (n == 1)
				{
					return 1;
				}
				else
				{
					return (Fibonacci(n - 1) + Fibonacci(n - 2));
				}
    }
}

public interface IFibonacciKillerKata
{
    /// <summary>
    /// Calculate an element of the Fibonacci sequence
    /// </summary>
    /// <param name="n">element number</param>
    /// <returns>n-th element of the Fibonacci sequence</returns>
    int Fibonacci(int n);
}

public class Test
{
	public static void Main()
	{
		IFibonacciKillerKata kata = new FibonacciKillerKata();
		int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		foreach (int i in arr)
		{
			Console.WriteLine("{0}th Fibonacci Number: {1}", i, kata.Fibonacci(i));	
		}
	}
}