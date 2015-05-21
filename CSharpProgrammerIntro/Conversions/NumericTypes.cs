class Test
{
	public static void Main()
	{
		sbyte v = 55;
		System.Console.WriteLine(v);
		short v2 = v;
		System.Console.WriteLine(v2);
		int v3 = v2;
		System.Console.WriteLine(v3);
		long v4 = v3;
		System.Console.WriteLine(v4);
		
		v3 = (int) v4;
		System.Console.WriteLine(v3);
		v2 = (short) v3;
		System.Console.WriteLine(v2);
		v = (sbyte) v2;
		System.Console.WriteLine(v);
	}
}