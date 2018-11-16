// https://stackoverflow.com/questions/1209359/when-to-use-properties-and-methods

using System;
					
public class Program
{
	public static void Main()
	{
		string myString = Variables.Name;
		Console.WriteLine(myString);
	}
}


public class Variables
{
	public static string Name = "Test";
}


// Example 2
using System;
					
public class Program
{
	public static void Main()
	{
		var MyVars = new Variables();
		MyVars.Name = "The new value";
		Console.WriteLine(MyVars.Name);
	}
}


public class Variables
{
	public string Name { get; set; }
	public void MyTest()
	{
		var myNewVal = Name;
	}
	
}
