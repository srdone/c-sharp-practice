private static void Main()
{
	IMessageWriter writer = 
		new SecureMessageWriter(
			new ConsoleMessageWriter();
		)
	
	var salutation = new Salutation(writer);
	Salutation.Exclaim();
}