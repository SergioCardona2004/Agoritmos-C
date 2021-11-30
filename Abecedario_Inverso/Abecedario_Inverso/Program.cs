using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EJERCICIO_PROPUESTO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("ABECEDARIO INVERSO");
            Console.WriteLine();
            for (i = 90; i >= 65; i--)
            {
                Console.WriteLine("LETRA: " + Convert.ToString((char)i));
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
