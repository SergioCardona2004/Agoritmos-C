using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
 class Program
 {
 static void Main(string[] args)
 {
 const int BASE =2;
 int NUM = 0;
 int AUX = 0;
 int POS = 0;
 int I = 0;
 int [] VEC = new int[21];
 string linea;
 Console.Write("DIGITE UN NÚMERO:");
 linea = Console.ReadLine();
 NUM = int.Parse(linea);
 POS = 1;
 while ((NUM >= BASE))
 {
 AUX = NUM % BASE;
 VEC[POS] = AUX;
 POS = POS + 1;
 NUM = NUM / BASE;
 }
 VEC[POS] = NUM;
 // SALIDA
 for (I = POS; I >= 1; I += -1)
 {
                Console.Write(VEC[I] + " ");
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
