using System;

//polygon class.
public class Polygon
{
	protected int width, height;

	public void setValues(int width, int height) {
		this.width = width;
		this.height = height;
	}
}

public class Rectangle : Polygon
{
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
		Rectangle a = new Rectangle();
		Triangle	  b = new Triangle();
		a.setValues(10,3);
		b.setValues(10,3);
		Console.WriteLine("Area of a: "+a.area());
		Console.WriteLine("Area of b: "+b.area());
	}	
}
