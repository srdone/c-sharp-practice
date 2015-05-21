//to build with tests:
//mcs Calculator.cs CalculatorSpec.cs -reference:nunit.framework.dll
//To run tests:
//NUNIT-CONSOLE Calculator.exe

namespace Katas
{
	using NUnit.Framework;
	
	[TestFixture]
	public class CalculatorSpec
	{
		string emptyString;
		string seven;
		
		[SetUp]
		public void init()
		{
			emptyString = "";
			seven = "7";
		}
		
		[Test]
		public void AddEmptyString()
		{
			var result = Calculator.Add(emptyString);
			
			Assert.AreEqual(0, result);
		}
		
		[Test]
		public void AddSeven()
		{
			var result = Calculator.Add(seven);
			
			Assert.AreEqual(7, result);
		}
	}
}