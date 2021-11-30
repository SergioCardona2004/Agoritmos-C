using System;

class ejercicio
{
    static void Main()
    {
        float num;

        Console.Write("Ingrese número:");
        num = float.Parse(Console.ReadLine());

        if (num == 0)
            Console.Write("El {0} no es negativo ni positivo es neutro", num);

        if (num > 0)
            Console.Write("El {0} es positivo", num);
        if (num < 0)
            Console.Write("El {0} es negativo", num);

        Console.Read();
    }
}