namespace Bank
{
	using System;
	public class Account{
		private decimal minimumBalance = 10m;
		
		public decimal Balance {get; private set;}
		public decimal MinimumBalance { get {return minimumBalance; }}
		
		public void TransferFunds(Account destination, decimal amountToTransfer)
		{
			if ((Balance - MinimumBalance) < amountToTransfer) {
				throw new InsufficientFundsException();
			}
			this.Withdraw(amountToTransfer);
			destination.Deposit(amountToTransfer);
		}
		
		public void Deposit(decimal amountToDeposit)
		{
			Balance += amountToDeposit;
		}
		
		public void Withdraw(decimal amountToWithdraw)
		{
			Balance -= amountToWithdraw;
		}
	}
	
	public class InsufficientFundsException : ApplicationException
	{
	}
}

public class Test
{
	public static void Main()
	{
		
	}
}