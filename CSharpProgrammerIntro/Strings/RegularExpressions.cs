//compile with: mcs -reference:system.text.regularexpressions.dll RegularExpressions.cs

using System;
using System.Text.RegularExpressions;

class Test
{
	public static void Main()
	{
		string s = "Oh, I hadn't thought of that";
		Regex regex = new Regex(@"( |, )");
		char[] separators = new char[] {' ', ','};
		foreach (string sub in regex.Split(s))
		{
			Console.WriteLine("Word: {0}", sub);
		}
	}
}