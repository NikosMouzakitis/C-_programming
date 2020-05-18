using System;

public class HelloWorld
{
	enum days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
	const double pi = 3.14159;	

	static public void Main()
	{
		var daysType = typeof(days);
		Console.WriteLine("Pi type: "+pi.GetType()+"\n");
		Console.WriteLine("type of days: "+daysType+"\n");
		Console.WriteLine("First name: "+days.Sat+"\n");
		Console.WriteLine("First name: "+(int)days.Sat+"\n");
		string name = Enum.GetName(daysType, 1);
		Console.WriteLine("name of days 1: "+name+"\n");
	}	

}
