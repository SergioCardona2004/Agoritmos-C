using System;

class ejercicio
{

    static void Main()
    {

        float num;

        Console.Write("Ingrese número:");
        num = float.Parse(Console.ReadLine());

        while (num == 0)
        {
            Console.Write("Reingrese número:");
            num = float.Parse(Console.ReadLine());
        }

        if (num % 2 == 0)
            Console.Write("El {0} es par", num);
        else
            Console.Write("El {0} es impar", num);

        Console.Read();

    }
}