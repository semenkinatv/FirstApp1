using System;

class MainClass
{
	public static void Main(string[] args)
	{

		string myName;
		myName = "Tatiana";

		Console.WriteLine(myName);
		Console.WriteLine("Привет,\n мир!");
		Console.WriteLine("\t My name is \n {0}", myName);
		Console.WriteLine('\u0040');
		Console.WriteLine('\x23');
		Console.WriteLine('\u005D');
		Console.ReadKey();
	}
}