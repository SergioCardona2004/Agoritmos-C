using System;

namespace Ejercicios
{
    class Ejercicio1

    {
        static void Main()
        {
            int i = 0;
            float num, acu = 0;

            while (i < 5)
            {
                Console.Write("Ingrese {0}º número:", i + 1);
                num = float.Parse(Console.ReadLine());
                acu += num;
                i++;
            }
            Console.Write("El promedio de los 5 números es {0}", acu / 5);
            Console.Read();
        }

    }
}