namespace Katas
{
	public class Calculator
	{
		public static int Add(string value)
		{
			if (value == "")
			{
				return 0;
			}
			else
			{
				return int.Parse(value);
			}
		}
	}
	
	class FakeMain
	{
		public static void Main() {}
	}
}