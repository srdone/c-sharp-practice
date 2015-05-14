// Copying from C# in Depth for practice/better understanding

static void HandleDemoEvent(object sender, EventArgs e)
{
	Console.WriteLine("Handled by HandleDemoEvent");
}

//Explicitly specifying delegate type and method
EventHandler handler;
handler = new EventHandler(HandleDemoEvent);
handler(null, EventArgs.Empty);

//Implicit conversion to delegate instance
handler = HandleDemoEvent;
handler(null, EventArgs.Empty);

//Specifies action with anonymous method
handler = delegate(object sender, EventArgs e)
{
	Console.WriteLine("Handled Anonymously");
};
handler(null, EventArgs.Empty);

//uses anonymous method shortcut
handler = delegate
{
	Console.WriteLine("Handled Anonymously Again");
};
handler(null, EventArgs.Empty);

//uses delegate contravariance
MouseEventHandler mouseHandler = HandleDemoEvent;
mouseHandler(null, new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0));

//Lambda expressions - like improved anonymous methods
Func<int, int, string> func = (x, y) => (x * y).ToString();
Console.WriteLine(func(3, 5));

//C# 3 - Anonymous types and implicit typing
var jon = new {Name = "Jon", Age = 31};
var tom = new { Name = "Tom", Age = 4 };
Console.WriteLine("{0} is {1}", jon.Name, jon.Age);

//Extension methods
string x = "Hello world".Reverse();

//Creating an Extension method
namespace ExtensionMethods
{
	public static class MyExtensions
	{
		public static int WordCount(this String str)
		{
			return str.Split(new char[] {' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
		}
	}
}