using System;

class Color
{
	int red;
	int green;
	int blue;
	
	public Color(int red, int green, int blue)
	{
		this.red = red;
		this.green = green;
		this.blue = blue;
	}
	
	public static readonly Color Red;
	public static readonly Color Green;
	public static readonly Color Blue;
	
	static Color()
	{
		Red = new Color(255, 0, 0);
		Green = new Color(0, 255, 0);
		Blue = new Color(0, 0, 255);
	}
	
	public override string ToString()
	{
		return this.red + " " + this.green + " " + this.blue;
	}
}

class Test
{
	public static void Main()
	{
		Color background = Color.Red;
		Console.WriteLine(background);
	}
}