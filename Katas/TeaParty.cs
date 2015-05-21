using System;

public class TeaPartyKata : ITeaPartyKata
{
    public string Welcome(string lastName, bool isWoman, bool isSir)
    {
        string welcomeString = "Hello";
				if (isWoman)
				{
					welcomeString = welcomeString + " " + "Ms.";
				}
				else if (isSir)
				{
					welcomeString = welcomeString + " " + "Sir";
				}
				else {
					welcomeString = welcomeString + " " + "Mr.";
				}
				
				welcomeString = welcomeString + " " + lastName;
				
				return welcomeString;
    }
}

public interface ITeaPartyKata
{
    /// <summary>
    /// Welcome a guest
    /// </summary>
    /// <param name="lastName">the last name of the guest</param>
    /// <param name="isWoman"><c>true</c> if the guest is female</param>
    /// <param name="isSir"><c>true</c> if the guest was knighted by the queen</param>
    /// <returns>issues welcome text to the guest</returns>
    string Welcome(string lastName, bool isWoman, bool isSir);
}

public class Test
{
	public static void Main()
	{
		TeaPartyKata kata = new TeaPartyKata();
		Console.WriteLine(kata.Welcome("Done", false, false));
		Console.WriteLine(kata.Welcome("Willie", true, false));
		Console.WriteLine(kata.Welcome("John", false, true));
	}
}