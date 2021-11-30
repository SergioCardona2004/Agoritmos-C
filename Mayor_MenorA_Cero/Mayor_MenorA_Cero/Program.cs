using System;

class Ejercicio3
{
    static void Main()
    {
        float numero;
        uint cont = 0, menor = 0, mayor = 0;

        while (cont < 10)
        {
            Console.Write("Ingrese número:");
            numero = float.Parse(Console.ReadLine());

            if (numero > 0)
                mayor++;
            if (numero < 0)
                menor++;

            cont++;
        }

        Console.WriteLine("De 10 números son ...\nMenores a 0  = {0} y mayores a 0 = {1}", menor, mayor);
        Console.ReadLine();
    }
}