using System;
using System.IO; //included for StreamReader.

public class HelloExceptions
{
	static public void Main()
	{
		Console.WriteLine("Start");
		string fileName = "wrong.txt"; //if file doesn't exist it will throw an application exception.
		ReadFile(fileName);
	}	

	static void ReadFile(string fileName)
	{
		try {
			TextReader reader = new StreamReader(fileName);
			string line = reader.ReadLine();
			Console.WriteLine(line);
			reader.Close();
		} catch(FileNotFoundException fnfe) {
			Console.WriteLine("The file '{0}' is not found.!", fileName);
		} catch(IOException ioe) {
			Console.WriteLine(ioe.StackTrace);
		}
	}
}
