using System;

class Engineer
{
	private string name;
	protected float billingRate;
	
	public Engineer(string name, float billingRate)
	{
		this.name = name;
		this.billingRate = billingRate;
	}
	
	public float CalculateCharge(float hours)
	{
		return hours * billingRate;
	}
	
	public string TypeName()
	{
		return "Engineer";
	}
}

class CivilEngineer : Engineer
{
	public CivilEngineer (string name, float billingRate) : base (name, billingRate) {}
	
	public new float CalculateCharge(float hours)
	{
		if (hours < 1.0f)
		{
			hours = 1.0f;
		}
		
		return hours * billingRate;
	}
	
	public new string TypeName()
	{
		return "Civil Engineer";
	}
}

class Test
{
	public static void Main()
	{
		Engineer[] engineerArray = new Engineer[2];
		engineerArray[0] = new Engineer("George", 15.50f);
		engineerArray[1] = new CivilEngineer("Sir John", 40f);
		
		Console.WriteLine("{0} charge = {1}", engineerArray[0].TypeName(), engineerArray[0].CalculateCharge(2f));
		Console.WriteLine("{0} charge = {1}", engineerArray[0].TypeName(), engineerArray[0].CalculateCharge(0.75f));
	}
}