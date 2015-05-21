using System;

interface IFoo
{
	void Execute();
}

interface IBar
{
	void Execute();
}

class Tester: IFoo, IBar
{
	void IFoo.Execute()
	{
		Console.WriteLine("IFoo.Execute Implementation");
	}
	
	void IBar.Execute()
	{
		Console.WriteLine("IBar.Execute Implementation");
	}
}

class Test
{
	public static void Main()
	{
		Tester tester = new Tester();
		
		IFoo iFoo = (IFoo) tester;
		iFoo.Execute();
		
		IBar iBar = (IBar) tester;
		iBar.Execute();
		
		((IFoo)tester).Execute();
	}
}