//to build with tests:
//mcs GreatestCommonDivisor.cs GreatestCommonDivisorSpec.cs -reference:nunit.framework.dll
//To run tests:
//NUNIT-CONSOLE GreatestCommonDivisor.exe

namespace Kata
{
	using NUnit.Framework;
	
	[TestFixture]
	public class GreatestCommonDivisorTest
	{
		[Test]
		public void BasicTest()
		{
			int x1 = 10;
			int x2 = 5;
			int gcd = 5;
			
			int result = GreatestCommonDivisor.Calculate(x1, x2);
			
			Assert.AreEqual(gcd, result);
		}
		
		[Test]
		public void One_Is_Only_GCD()
		{
			int x1 = 3;
			int x2 = 2;
			int gcd = 1;
			
			int result = GreatestCommonDivisor.Calculate(x1, x2);
			
			Assert.AreEqual(gcd, result);
		}
	}
}