using System;

class MainClass
{
	public static void Main(string[] args)
	{

		string MyName = "Tatiana";
		byte MyAge = 46;
		bool HaveIApet = true;
		double MyShoeSize = 39.5;

		Console.WriteLine(MyName);
		Console.WriteLine("Привет,\n мир!");
		Console.WriteLine("\t My name is \n {0}", MyName);
		Console.WriteLine('\u0040');
		Console.WriteLine('\x23');

		Console.WriteLine("My name is " + MyName);
		Console.WriteLine("My age is " + MyAge);
		Console.WriteLine("Do I have a pet? " + HaveIApet);
		Console.WriteLine("My shoe size is " + MyShoeSize);

		Console.WriteLine("Intmin {0}", int.MinValue);
		Console.WriteLine("Intmax {0}", int.MaxValue);

		Console.ReadKey();
	}
}