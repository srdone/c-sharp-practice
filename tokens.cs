using System
using System.Collections

public class Tokens
{
	private string[] elements;
	
	Tokens(string source, char[] delimiters)
	{
		elements = source.Split(delimiters);
	}
	
	public GetEnumerator()
	{
		return new TokenEnumerator(this);
	}
	
	private class TokenEnumerator
	{
		private int position = -1;
		private Tokens t;
		
		public TokenEnumerator(Tokens t)
		{
			this.t = t;
		}
		
		public bool MoveNext()
		{
			if (position < t.elements.Length - 1)
			{
				position++;
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public void Reset()
		{
			position = -1;
		}
		
		public string Current
		{
			get
			{
				return t.elements[position];
			}
		}
	}
	
	static void Main()
	{
		Tokens f = new Tokens("This is a well-done program", new char[] {' ', '-'});
		foreach (string item in f)
		{
			Console.WriteLine(item);
		}
	}
}