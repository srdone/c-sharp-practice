using System;

public class Scout
{
	private string firstName;
	public string FirstName
	{
		get { return firstName; }
		set
		{
			firstName = value.ToUpper();
		}
	}
	
	public string LastName;
	
	public string FullName
	{
		get { return FirstName + ' ' + LastName;}
	}
}

public class Program {
	static void Main()
	{
		Scout scout1 = new Scout();
		scout1.FirstName = "bill";
		scout1.LastName = "Codner";
		Console.WriteLine("{0} {1}", scout1.FirstName, scout1.LastName);
		Console.WriteLine(scout1.FullName);
	}
}