using System;
public abstract class MusicServer
{
	public abstract void Play();
}

public class WinAmpServer: MusicServer
{
	public override void Play() {
		Console.WriteLine("WinampServer.Play()");
	}	
}

public class MediaServer: MusicServer
{
	public override void Play() {
		Console.WriteLine("MediaServer.Play()");
	}
}

class Test
{
	public static void CallPlay(MusicServer ms)
	{
		ms.Play();
	}
	
	public static void Main()
	{
		MusicServer ms = new WinAmpServer();
		CallPlay(ms);
		ms = new MediaServer();
		CallPlay(ms);
	}
}