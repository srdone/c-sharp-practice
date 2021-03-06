using System;

struct Complex
{
	public float real;
	public float imaginary;
	
	public Complex(float real, float imaginary)
	{
		this.real = real;
		this.imaginary = imaginary;
	}
	
	public override string ToString()
	{
		return String.Format("({0}, {1})", real, imaginary);
	}
}

class Test
{
	public static void Main()
	{
		Complex myNumber1;
		Complex myNumber2;
		Complex myNumber3;
		
		myNumber1 = new Complex();
		Console.WriteLine("Number 1: {0}", myNumber1);
		
		myNumber2 = new Complex(5.0f, 4.0f);
		Console.WriteLine("Number 2: {0}", myNumber2);
		
		myNumber3.real = 1.5f;
		myNumber3.imaginary = 15f;
		Console.WriteLine("Number 3: {0}", myNumber3);
	}
}