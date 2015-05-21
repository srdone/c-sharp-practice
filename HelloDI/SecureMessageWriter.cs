public class SecureMessageWriter
{
	private readonly IMessageWriter writer;
	
	public SecureMessageWriter(IMessageWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		this.writer = writer;
	}
	
	public void Write(string message)
	{
		if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
		{
			this.writer.Write(message);
		}
	}
}