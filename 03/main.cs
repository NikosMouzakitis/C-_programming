using System;

public class HelloWorld
{
	static void printVar(int a) {

		Console.WriteLine("value is: "+a+" sqared is: "+a*a);

	}
	static public void Main()
	{
		String[] cars = new String[3] { "BMW", "Ford", "Opel"};

		//iterate throught array
		int i;	
		for(i = 0; i <3;i++)
			Console.Write("car : "+ i+ "is: "+ cars[i]+"\n");


		int[,] coords = new int[2,3]{{1,2,3},{4,5,6}};
		int j;

		for(j = 0; j <3;j++)
			for(i = 0; i <2;i++)
				Console.WriteLine(i+" "+j+" is: "+coords[i,j]+"\n");
	}	

}
