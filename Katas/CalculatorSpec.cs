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
		string six;
		string five;
		string four;
		string three;
		string sevenAndSix;
		string randomIntString;
		int randomInt;
		
		[SetUp]
		public void init()
		{
			emptyString = "";
			seven = "7";
			six = "6";
			five = "5";
			four = "4";
			three = "3";
			sevenAndSix = seven + "," + six;
			
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
		
		[Test]
		public void AddTwoInts()
		{
			var result = Calculator.Add(seven, six);
			
			Assert.AreEqual(13, result);
		}
		
		[Test]
		public void Add2IntsSeparatedByCommas()
		{
			var result = Calculator.Add(sevenAndSix);
			
			Assert.AreEqual(13, result);
		}

		private string concatenateWithCommas(params string[] values)
		{
			return String.Join(",", values);
		}
		
		[Test]
		public void Add5IntsSeparatedByCommas()
		{
			var sevenSixFiveFourThree = concatenateWithCommas(seven, six, five, four, three);
			var result = Calculator.Add(sevenSixFiveFourThree);
			
			Assert.AreEqual(7 + 6 + 5 + 4 + 3, result);
		}
		
		[Test]
		public void Add5IntsSeparatedByCommasWithSomeNegative()
		{
			string negativeSeven = "-" + seven;
			string negativeFive = "-" + five;
			var sumString = concatenateWithCommas(negativeSeven, six, negativeFive, four, three);
			var result = Calculator.Add(sumString);
			
			Assert.AreEqual(-7 + 6 + -5 + 4 + 3, result);
		}
	}
}