using System;
class Circle
{
	private int _x;
	public int X
	{
		get
		{
			return _x;
		}
		set
		{
			_x = value;
		}
	}
}

class Test
{
	public static void Main()
	{
		Circle circle = new Circle();
		circle.X = 3;
		Circle circle2 = new Circle();
		circle2.X = 4;
		Console.WriteLine("Circle X value: {0}", circle.X);
		Console.WriteLine("Circle2 X value: {0}", circle2.X);
	}
}