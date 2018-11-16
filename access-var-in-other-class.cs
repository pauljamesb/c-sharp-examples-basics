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
