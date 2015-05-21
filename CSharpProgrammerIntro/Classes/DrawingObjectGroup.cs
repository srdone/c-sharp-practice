public class DrawingObjectGroup
{
	public DrawingObjectGroup()
	{
		objects = new DrawingObject[10];
		objectCount = 0;
	}
	public void AddObject(DrawingObject obj)
	{
		if (objectCount < 10)
		{
			objects[objectCount] = obj;
			objectCount++;
		}
	}
	public void Render()
	{
		for (int i = 0; i < objectCount; i++)
		{
			objects[i].Render();
		}
	}
	
	DrawingObject[] objects;
	int objectCount;
}

public class DrawingObject
{
	internal void Render() {}
}

class Test
{
	public static void Main()
	{
		DrawingObjectGroup group = new DrawingObjectGroup();
		for (int i = 0; i < 20; i++)
		{
			group.AddObject(new DrawingObject());
		}
		
	}
}