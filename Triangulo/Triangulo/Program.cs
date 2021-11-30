using System;

class Ejercicio
{
    static void Main()
    {
        float bas, alt;

        Console.Write("Ingrese base:");
        bas = float.Parse(Console.ReadLine());
        Console.Write("Ingrese altura:");
        alt = float.Parse(Console.ReadLine());

        Console.Write("El area del triangulo es {0}", (bas * alt) / 2);
        Console.ReadLine();
    }

}