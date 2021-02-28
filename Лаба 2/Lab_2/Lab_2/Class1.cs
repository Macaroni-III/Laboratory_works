using System;

public class Singleton
{
	public static Singleton Instance
	{
		get
		{
			if (instance == null) instance = new Singleton();
			return instance;
		}
	}
	public void Method1() { Console.WriteLine("Singleton.Method1"); }
	public void Method2() { Console.WriteLine("Singleton.Method2"); }
	private Singleton() { }
	private static Singleton instance;
}
