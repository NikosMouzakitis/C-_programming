using System;

public class Dog
{
	private string name;
	private int	age;
	private	string	color;

	public Dog(string nm, int ag, string cl) {
		name = nm;
		age = ag;
		color = cl;
	}
	//setters-getters
	public void setName(string tag) { name = tag; }
	public string getName() { return name;}
	public void setAge(int tag) { age = tag;}
	public int getAge() { return age; }
	public void setColor(string tag) { color = tag; }
	public string getColor() { return color;}

	// a method of dog class.
	public void bark() {
		Console.WriteLine("woof");
	}
	public void printDetails() {
		Console.WriteLine("Name: "+name);
		Console.WriteLine("Age: " + age);
		Console.WriteLine("Color: "+color);
	}
	static public void Main()
	{
		Console.WriteLine("Start");
		
		Dog jack = new Dog("jack", 4, "brown");
		jack.bark();
		jack.printDetails();
		jack.setAge(19);
		Console.WriteLine("Age: "+jack.getAge());
	}	
}
