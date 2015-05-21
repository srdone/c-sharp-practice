//example with early binding
private static void Main()
{
	IMessageWriter writer = new ConsoleMessageWriter();
	var salutation = new Saluation(writer);
	saluation.Exclaim();
}