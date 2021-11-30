using System;

namespace Ejercicios
{
    class Ejercicio2
    {
        static void Main()
        {
            float num;

            Console.Write("Ingrese un número:");
            num = float.Parse(Console.ReadLine());

            while (num < 1)
            {
                Console.Write("ERROR.Reingrese número:");
                num = float.Parse(Console.ReadLine());
            }

            Console.Write("El cuadrado de {0} es {1}", num, num * num);
            Console.Read();
        }

    }
}
