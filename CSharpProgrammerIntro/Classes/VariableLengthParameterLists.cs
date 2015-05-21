using System;
class Port
{
	public void Write(string label, object arg)
	{
		WriteString(label);
		WriteString(arg.ToString());
	}
	
	public void Write(string label, params object[] args)
	{
		WriteString(label);
		for (int i = 0; i < args.Length; i++)
		{
			WriteString(args[i].ToString());
		}
	}
	
	void WriteString(string str)
	{
		Console.WriteLine("Port debug: {0}", str);
	}
}

class Test
{
	public static void Main()
	{
		Port port = new Port();
		port.Write("Single Test", "Port ok");
		port.Write("Port Test: ", "a", "b", 12, 14.2);
		object[] arr = new object[4];
		arr[0] = "The";
		arr[1] = "answer";
		arr[2] = "is";
		arr[3] = 42;
		port.Write("What is the answer?", arr);
	}
}