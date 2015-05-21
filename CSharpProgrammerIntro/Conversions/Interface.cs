using System;
interface IDebugDump
{
	string DumpObject();
}

class Simple
{
	private int value;
	public Simple(int value)
	{
		this.value = value;
	}
	public override string ToString()
	{
		return(value.ToString());
	}
}

class Complicated: IDebugDump
{
	public Complicated(string name)
	{
		this.name = name;
	}
	public override string ToString()
	{
		return name;
	}
	string IDebugDump.DumpObject()
	{
		return String.Format(
			"{0}\nLatency: {0}\nRequests: {1}\nFailures: {0}\n",
			new object[] {name, latency, requestCount, failedCount}
		);
	}
	string name;
	int latency = 0;
	int requestCount = 0;
	int failedCount = 0;
}

class Test
{
	public static void DoConsoleDump(params object[] arr)
	{
		foreach (object o in arr)
		{
			IDebugDump dumper = o as IDebugDump;
			if (dumper != null)
			{
				Console.WriteLine("{0}", dumper.DumpObject());
			}
			else
			{
				Console.WriteLine("{0}", o);
			}
		}
	}
	
	public static void Main()
	{
		Simple s = new Simple(13);
		Complicated c = new Complicated("Tracking Test");
		DoConsoleDump(s, c);
	}
}