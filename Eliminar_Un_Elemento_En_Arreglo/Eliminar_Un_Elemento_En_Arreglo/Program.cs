using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace taller_57
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 0;
            int CAN = 0;
            int POS = 0;
            String cad;
            Console.Write("CUANTOS ELEMENTOS :");
            cad = Console.ReadLine();
            CAN = int.Parse(cad);
            int[] VEC = new int[CAN + 1];
            int[] NUEVO = new int[CAN];
            // INGRESO
            for (I = 1; I <= CAN; I++)
            {
                Console.Write("POSICIÓN {0} ==>", I);
                cad = Console.ReadLine();
                VEC[I] = int.Parse(cad);
            }
            do
            {
                Console.Write("POSICIÓN A ELIMINAR:");
                cad = Console.ReadLine();
                POS = int.Parse(cad);
            } while (((POS < 1) | (POS > CAN)));
            // PROCESO
            // TRANSLADAMOS DATOS ANTES DE LA POSICIÓN
            for (I = 1; I <= POS - 1; I++)
            {
                NUEVO[I] = VEC[I];
            }
            // TRANSLADAMOS DATOS DESPUES DE LA POSICIÓN
            for (I = POS + 1; I <= CAN; I++)
            {
                NUEVO[I - 1] = VEC[I];
            }
            // SALIDA
            Console.WriteLine();
            Console.WriteLine("NUEVO ARREGLO");
            for (I = 1; I <= CAN - 1; I++)
            {
                Console.WriteLine(NUEVO[I]);
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}