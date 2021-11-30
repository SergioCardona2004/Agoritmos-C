using System;
/*Números impares entre 0 y 100*/

class ejercicio
{
    static void Main()
    {
        int i, impar = 0, par = 0;

        for (i = 0; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write("{0}|", i);
                impar++;
            }
        }
    }
}