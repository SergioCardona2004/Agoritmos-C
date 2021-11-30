using System;
public class Exercise2
{
	public static void Main()
	{
		int i, j, rows;

		Console.Write("Escriba un numero: ");
		rows = Convert.ToInt32(Console.ReadLine());
		for (i = 1; i <= rows; i++)
		{
			for (j = 1; j <= i; j++)
				Console.Write("{0}", j);
			Console.Write("\n");
		}
	}
}
