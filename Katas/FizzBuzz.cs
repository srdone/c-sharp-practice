using System;

public class FizzBuzzKata
{
    public static string Answer(int i)
    {
        bool fizz = (i % 3) == 0;
        bool buzz = (i % 5) == 0;
        bool fizzbuzz = (((i % 3) == 0) && ((i % 5) == 0));
        
        if (fizzbuzz)
        {
            return "fizz buzz";
        }
        else if (fizz)
        {
            return "fizz";
        }
        else if (buzz)
        {
            return "buzz";
        }
        else
        {
            return i.ToString();
        }
    }
}

public class Test
{
	public static void Main()
	{
		int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
		foreach (int val in arr)
		{
			var answer = FizzBuzzKata.Answer(val);
			Console.WriteLine(answer);
		}
	}
}