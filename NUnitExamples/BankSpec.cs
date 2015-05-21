//to build with tests:
//mcs Bank.cs BankSpec.cs -reference:nunit.framework.dll
//To run tests:
//NUNIT-CONSOLE Bank.exe

namespace Bank
{
	using NUnit.Framework;
	
	[TestFixture]
	public class AccountTest
	{
		Account source;
		Account destination;
		
		[SetUp]
		public void init()
		{
			source = new Account();
			source.Deposit(200m);
			
			destination = new Account();
			destination.Deposit(150m);
		}
		
		[Test]
		public void TransferFunds()
		{
			source.TransferFunds(destination, 100m);
			
			Assert.AreEqual(250m, destination.Balance);
			Assert.AreEqual(100m, source.Balance);
		}
		
		[Test]
		[ExpectedException(typeof(InsufficientFundsException))]
		public void TransferWithInsufficientFunds()
		{	
			source.TransferFunds(destination, 191m);
		}
		
		[Test]
		public void TransferWithInsufficientFundsAtomicity()
		{	
			try
			{
				source.TransferFunds(destination, 191m);
			}
			catch (InsufficientFundsException)
			{
			}
			
			Assert.AreEqual(200m, source.Balance);
			Assert.AreEqual(150m, destination.Balance);
		}
	}
}