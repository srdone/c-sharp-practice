//Note: suffers from the Constrained Construction anti-pattern

private static void Main()
{
	var typeName = ConfigurationManager.AppSettings["messageWriter"];
	var type = Type.GetType(typeName, true);
	IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);
	
	var salutation = new Salutation(writer);
	Salutation.Exclaim();
}