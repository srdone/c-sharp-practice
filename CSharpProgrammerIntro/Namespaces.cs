namespace Outer
{
	namespace Inneer
	{
		class MyClass
		{
			public static void Function() {}
		}
	}
}

//equivalent:
namespace Outer.Inner
{
	class MyClass
	{
		public static void Function() {}
	}
}