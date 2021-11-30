using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace taller_56
{
    class Program
    {
        static void Main(string[] args)
        {
            byte I = 0;
            byte CAN = 0;
            byte POS = 0;
            int ELE = 0;
            String cad;
            Console.Write("CUANTOS ELEMENTOS :");
            cad = Console.ReadLine();
            CAN = byte.Parse(cad);
            int[] VEC = new int[CAN + 1];
            int[] NUEVO = new int[CAN + 2];
            // INGRESO
            for (I = 1; I <= CAN; I++)
            {
                Console.Write("POSICIÓN {0} ==>", I);
                cad = Console.ReadLine();
                VEC[I] = int.Parse(cad);
            }
            Console.Write("ELEMENTO A INSERTAR:");
            cad = Console.ReadLine();
            ELE = int.Parse(cad);
            do
            {
                Console.Write("POSICIÓN A INSERTAR:");
                cad = Console.ReadLine();
                POS = byte.Parse(cad);
            } while (((POS < 1) | (POS > CAN)));
            // PROCESO
            // TRANSLADAMOS DATOS ANTES DE LA POSICION
            for (I = 1; I <= POS - 1; I++)
            {
                NUEVO[I] = VEC[I];
            }
            // INSERTAMOS ELEMENTO
            NUEVO[POS] = ELE;
            // TRANSLADAMOS DATOS DESPUES DE LA POSICION
            for (I = POS; I <= CAN; I++)
            {
                NUEVO[I + 1] = VEC[I];
            }
            // SALIDA
            Console.WriteLine();
            Console.WriteLine("NUEVO ARREGLO");
            for (I = 1; I <= CAN + 1; I++)
            {
                Console.WriteLine(NUEVO[I]);
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadKey();
        }
    }
}