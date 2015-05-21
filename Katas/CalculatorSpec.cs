//to build with tests:
//mcs Calculator.cs CalculatorSpec.cs -reference:nunit.framework.dll
//To run tests:
//NUNIT-CONSOLE Calculator.exe

namespace Katas
{
	using NUnit.Framework;
	using System;
	
	[TestFixture]
	public class CalculatorSpec
	{
		string emptyString;
		string seven;
		string randomIntString;
		int randomInt;
		
		[SetUp]
		public void init()
		{
			emptyString = "";
			seven = "7";
			
			var random = new Random();
			randomInt = random.Next();
			randomIntString = randomInt.ToString();
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
		
		[Test]
		public void AddRandomInt()
		{
			var result = Calculator.Add(randomIntString);
			
			Assert.AreEqual(randomInt, result);
		}
		
		[Test]
		public void AddRandomNegativeInt()
		{
			var negativeRandomInt = -randomInt;
			var negativeRandomIntString = "-" + randomIntString;
			
			var result = Calculator.Add(negativeRandomIntString);
			
			Assert.AreEqual(negativeRandomInt, result);
		}
	}
}