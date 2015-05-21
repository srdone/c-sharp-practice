namespace Kata
{
	using NUnit.Framework;
	
	[TestFixture]
	public class BackwardsTalkTest
	{
		string test = "Hello";
		string reversed = "olleH";
		
		[Test]
		public void ReverseWord()
		{
			string result = BackwardsTalk.Revert(reversed);
			
			Assert.AreEqual(test, result);
		}
	}
}