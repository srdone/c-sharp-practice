public class DiagramObject
{
	public DiagramObject() {}
}

interface IScaleable
{
	void ScaleX(float factor);
	void ScaleY(float factor);
}

public class TextObject: DiagramObject, IScaleable
{
	public TextObject(string text)
	{
		this.text = text;
	}
	
	public void ScaleX(float factor)
	{
		//scale the object here
	}
	
	public void ScaleY(float factor)
	{
		// scale the object here
	}
	
	private string text;
}

class Test
{
	public static void Main()
	{
		TextObject text = new TextObject("Hello");
		
		IScaleable scaleable = (IScaleable)text;
		scaleable.ScaleX(0.5f);
		scaleable.ScaleY(0.5f);
	}
}