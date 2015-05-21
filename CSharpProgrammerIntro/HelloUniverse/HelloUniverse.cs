using System;

class Hello
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello, Universe");
		
		for (int arg = 0; arg < args.Length; arg++)
		{
			Console.WriteLine("Arg {0}: {1}", arg, args[arg]);
		}
	}
}