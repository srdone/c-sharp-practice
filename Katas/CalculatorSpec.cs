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
		string two;
		string sevenAndSix;
		string randomIntString;
		int randomInt;
		Calculator calculator;
		
		[TestFixtureSetUp]
		public void Init()
		{
			emptyString = "";
			seven = "7";
			six = "6";
			five = "5";
			four = "4";
			three = "3";
			two = "2";
			sevenAndSix = seven + "," + six;
		}
		
		[SetUp]
		public void init()
		{
			var random = new Random();
			randomInt = random.Next();
			randomIntString = randomInt.ToString();
			
			calculator = new Calculator();
		}
		
		[Test]
		public void AddEmptyString()
		{
			var result = calculator.Add(emptyString).Equals();
			
			Assert.AreEqual(0, result);
		}
		
		[Test]
		public void AddSeven()
		{
			var result = calculator.Add(seven).Equals();
			
			Assert.AreEqual(7, result);
		}
		
		[Test]
		public void AddRandomInt()
		{
			var result = calculator.Add(randomIntString).Equals();
			
			Assert.AreEqual(randomInt, result);
		}
		
		[Test]
		public void AddRandomNegativeInt()
		{
			var negativeRandomInt = -randomInt;
			var negativeRandomIntString = "-" + randomIntString;
			
			var result = calculator.Add(negativeRandomIntString).Equals();
			
			Assert.AreEqual(negativeRandomInt, result);
		}
		
		[Test]
		public void AddTwoInts()
		{
			var result = calculator.Add(seven, six).Equals();
			
			Assert.AreEqual(13, result);
		}
		
		[Test]
		public void Add2IntsSeparatedByCommas()
		{
			var result = calculator.Add(sevenAndSix).Equals();
			
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
			calculator.Add(sevenSixFiveFourThree);
			
			var result = calculator.Equals();
			
			Assert.AreEqual(7 + 6 + 5 + 4 + 3, result);
		}
		
		[Test]
		public void Add5IntsSeparatedByCommasWithSomeNegative()
		{
			string negativeSeven = "-" + seven;
			string negativeFive = "-" + five;
			var sumString = concatenateWithCommas(negativeSeven, six, negativeFive, four, three);
			
			var result = calculator.Add(sumString).Equals();
			
			Assert.AreEqual(-7 + 6 + -5 + 4 + 3, result);
		}
		
		[Test]
		public void CanRunAddTwiceAndGetCorrectResult()
		{
			calculator.Add(five);
			calculator.Add(seven);
			int result = calculator.Equals();
			
			Assert.AreEqual(12, result);
		}
		
		[Test]
		public void EqualsShouldNotResetTotal()
		{
			calculator.Add(five);
			int result1 = calculator.Equals();
			calculator.Add(seven);
			int result2 = calculator.Equals();
			
			Assert.AreEqual(5, result1);
			Assert.AreEqual(12, result2);
		}
		
		[Test]
		public void ResetShouldResetCalculatorToZero()
		{
			calculator.Add(five);
			calculator.Reset();
			int result = calculator.Equals();
			
			Assert.AreEqual(0, result);
		}
		
		[Test]
		public void ResetShouldReturnTheCalculatorInstance()
		{
			Calculator calculator2 = calculator.Reset();
			
			Assert.AreSame(calculator, calculator2);
		}
		
		[Test]
		public void TestComplexFluentAPI()
		{
			int result = calculator.Add(five).Add(seven).Reset().Add(three).Equals();
			
			Assert.AreEqual(3, result);
		}
		
		[Test]
		public void SubtractShouldSubtractTheValueProvided()
		{
			int result = calculator.Subtract(five).Equals();
			
			Assert.AreEqual(-5, result);
		}
		
		[Test]
		public void SubtractShouldBeFluent()
		{
			int result = calculator.Add(three).Subtract(four).Equals();
			
			Assert.AreEqual(-1, result);
		}
		
		[Test]
		public void SubtractShouldReturnTheCalculatorInstance()
		{
			Calculator calculator2 = calculator.Subtract(four);
			
			Assert.AreSame(calculator, calculator2);
		}
		
		[Test]
		public void SubtractShouldHandleNegativeValues()
		{
			string negativeFour = "-" + four;
			int result = calculator.Subtract(negativeFour).Equals();
			
			Assert.AreEqual(4, result);
		}
		
		[Test]
		public void SubtractShouldHandleMultipleValues()
		{
			string fourAndFive = concatenateWithCommas(four, five);
			int result = calculator.Subtract(fourAndFive).Equals();
			
			Assert.AreEqual(-9, result);
		}
		
		[Test]
		public void DivideShouldReturnTheCalculatorInstance()
		{
			Calculator calculator2 = calculator.Divide(seven);
			
			Assert.AreSame(calculator, calculator2);
		}
		
		[Test]
		public void DivideShouldDivideTheCurrentRunningValueByProvidedValue()
		{
			int result1 = calculator.Divide(seven).Equals();
			int result2 = calculator.Add(seven).Divide(seven).Equals();
			
			Assert.AreEqual(0, result1);
			Assert.AreEqual(1, result2);
		}
		
		[Test]
		public void DivideShouldTakeMultipleValues()
		{
			string twoAndTwo = concatenateWithCommas(two, two);
			calculator.Add(four).Divide(twoAndTwo);
			int result = calculator.Equals();
			
			Assert.AreEqual(1, result);
		}
		
		[Test]
		[Ignore("Deciding how to implement non-integers")]
		public void DivideShouldHandleResultsProducingRealNumbers()
		{
			
		}
	}
}