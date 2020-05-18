using System;

//polygon class.
public class Polygon
{
	protected int width, height;

	public Polygon() {
		Console.WriteLine("Polygon default empty constructor called");
	}

	public Polygon(int width, int height) {
		this.width = width;
		this.height = height;
		Console.WriteLine("Polygon default specific constructor called");
	}

	public void setValues(int width, int height) {
		this.width = width;
		this.height = height;
	}
}

public class Rectangle : Polygon
{
	public Rectangle(int width, int height) : base(width, height)
	{
		Console.WriteLine("Overloaded constructor for rectange");
	}
	public int area()
       	{ 
		return (this.width)*(this.height); 
	}
}

public class Triangle : Polygon 
{
	public double area() 
	{
		return ( (this.width) * (this.height) )/2 ;
	}
}


public class Hello
{
	static public void Main()
	{
		Console.WriteLine("Start");
		
		Rectangle a = new Rectangle(20,2);
		Triangle  b = new Triangle();
		Polygon	  c = new Polygon(10,2);
//		a.setValues(10,3);
		b.setValues(10,3);
		Console.WriteLine("Area of a: "+a.area());
		Console.WriteLine("Area of b: "+b.area());
	}	
}
