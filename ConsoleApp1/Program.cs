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
		Console.WriteLine();
		Console.WriteLine("Intmin {0}", int.MinValue);
		Console.WriteLine("Intmax {0}", int.MaxValue);
		Console.WriteLine();
		
		DaysOfWeek MyFavoriteDay;
		MyFavoriteDay = DaysOfWeek.Friday;

		Console.WriteLine(MyFavoriteDay);

		Semaphore SemColor;
		SemColor = Semaphore.Red;
		Console.WriteLine(SemColor);
		Console.WriteLine();
		Console.WriteLine("\tПривет,\n мир!");
		Console.WriteLine();
		Console.WriteLine($"Меня зовут {MyName}");
		Console.WriteLine();
		Console.WriteLine($"Мой возраст {MyAge}");
		
		var name = "Jane";
		var age = 27;
		var favcolor = "black";
		Console.WriteLine("\n{0} \n{1} \n{2}", name, age, favcolor);
		
		Console.WriteLine("\nВведите текст");
		string str = Console.ReadLine();
		Console.WriteLine("Ваш текст: {0}", str);

		double result = 10 % 3;
		Console.WriteLine("\n10 % 3 = {0}", result);

		Console.WriteLine("\nНазовите номер дня");
		DaysOfWeek day = (DaysOfWeek) int.Parse(Console.ReadLine());
		Console.WriteLine("Ваш день - {0}", day);

		Console.Write("Введите имя: ");
		name = Console.ReadLine();
		Console.Write("Введите Ваш возраст: ");
		var Myage = Convert.ToInt32(Console.ReadLine());
		Console.Write("Введите дату рождения: ");
		var birthdate = Console.ReadLine();
		Console.WriteLine("Ваше имя {0}, Ваш возраст {1}, Дата рождения {2}", name, Myage, birthdate);

		Console.ReadKey();
	}
}
enum DaysOfWeek : byte
{
	Tuesday,
	Monday,
	Wednesday,
	Friday
}
enum Semaphore : int
{
	Red = 100,
	Yellow = 200,
	Green = 300
}