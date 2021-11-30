using System;

class ejercicio28
{
    static void Main()
    {
        int num;

        do
        {
            Console.Write("Ing. un numero entre 0 y 10:");
            num = Int32.Parse(Console.ReadLine());

        } while (num < 1 || num > 9);

        for (int i = 1; i < 10; i++)
            Console.WriteLine("{0} x {1} = {2}", num, i, num * i);

        Console.Read();
    }
}