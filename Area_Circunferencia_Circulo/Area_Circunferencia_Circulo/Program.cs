using System;

class Ejercicio
{
    static void Main()
    {
        float radio;

        Console.Write("Ingrese radio:");
        radio = float.Parse(Console.ReadLine());

        Console.WriteLine("El perimetro del circulo es {0}", 3.1416 * (radio * 2));
        Console.Write("El area del circulo es {0}", 3.1416 * radio * radio);
        Console.ReadLine();
    }

}
