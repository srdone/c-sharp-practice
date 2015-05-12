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