using System;
delegate void StringProcessor(string input);
class Person
{
	string name;
	public Person (string name)
	{
		this.name = name;
	}
	
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	
	public void Say (string message)
	{
		Console.WriteLine("{0} says {1}", name, message);
	}
}

class Background
{
	public static void Note (string note)
	{
		Console.WriteLine("({0})", note);
	}
}

class SimpleDelegateUse
{
	static void Main()
	{
		Person jon = new Person("Jon");
		Person tom = new Person("Tom");
		StringProcessor jonsVoice, tomsVoice, background;
		jonsVoice = new StringProcessor(jon.Say);
		tomsVoice = new StringProcessor(tom.Say);
		background = new StringProcessor(Background.Note);
		jonsVoice("Hello, son.");
		tomsVoice.Invoke("Hello, daddy.");
		background("An Airplane flies past.");
		// Delegates refer to the instance in the state when it is invoked, not the state when created
		jon.Name = "Bill";
		jonsVoice("What is my name?");
	}
}