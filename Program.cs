using System;

//Uppgift 3.13

public class Program
{
	public static void Main()
	{
		// proggrammet frågar om hur gammal hen är om man svara mellan 16-19 år då får man vara med tävlingen annars nej 
		Console.WriteLine("Hur gammal är du? (år) ");
		int ålder = int.Parse(Console.ReadLine());

		if (ålder >= 20)
		{
			Console.WriteLine("du får inte vara med tävlingen du är för gammal ");
		}
		else if (ålder <= 15)
		{
			Console.WriteLine("du får inte vara med tävlingen du är för ung ");
		}
		else { Console.WriteLine("du får vara med tävlingen "); }




	}
}


