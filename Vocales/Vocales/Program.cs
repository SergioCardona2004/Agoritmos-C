using System;

class ejercicio
{
    static void Main()
    {
        string letra;
        uint a = 0, e = 0, i = 0, o = 0, u = 0;

        Console.Write("INGRESE UNA FRASE:");
        letra = Console.ReadLine();
        for (int x = 0; x < 20; x++)
        {
            if (letra[x] == 'a')
                a++;
            if (letra[x] == 'e')
                e++;
            if (letra[x] == 'i')
                i++;
            if (letra[x] == 'o')
                o++;
            if (letra[x] == 'u')
                u++;
        }
        Console.WriteLine("a = {0}, e = {1}, i = {2}, o = {3}, u = {4}", a, e, i, o, u);
        Console.Read();
    }
}