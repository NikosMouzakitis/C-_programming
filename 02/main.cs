using System;

public class HelloWorld
{
	static void printVar(int a) {

		Console.WriteLine("value is: "+a+" sqared is: "+a*a);

	}
	static public void Main()
	{
		Console.WriteLine("Start");
		printVar(12);	
		String userinput;
		userinput = Console.ReadLine(); //ReadLine returns String.
		Console.Write("User entered: "+userinput+"\n");
		Console.Write("How old are you?: ");
		userinput = Console.ReadLine(); //ReadLine returns String.
		int old = Convert.ToInt32(userinput);
		Console.Write("You are : "+old+"\n");
	}	

}
