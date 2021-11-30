using System;

namespace ejercicio
{
    class ejercicio32
    {
        static void Main()
        {
            float[] num = new float[5];
            float mayor = 0, menor = 0;
            int flag = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese {0}º número:", i + 1);
                num[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayor = num[i];
                    menor = num[i];
                    flag = 1;
                }
                else
                {
                    if (num[i] > mayor)
                        mayor = num[i];
                    if (num[i] < menor)
                        menor = num[i];
                }
            }
            if (mayor == menor)
                Console.Write("\nLos números son todos iguales\n");
            else
                Console.Write("\nEl menor de los 5 números es el {0} y el mayor es el {1}", menor, mayor);

            Console.Read();
        }
    }
}