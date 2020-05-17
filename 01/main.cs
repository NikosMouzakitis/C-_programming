using System;

public class HelloWorld
{
	static public void Main()
	{
		Console.WriteLine("Start");
		byte centuries = 20;
		ulong hours = 17531520;

		Console.WriteLine(centuries + " centuries and " + hours + " hours");
		Console.WriteLine("max int value is: "+ UInt64.MaxValue);
	}	

}
