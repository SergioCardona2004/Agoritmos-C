using System;

namespace Evalue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero binario: ");
            int binary = Convert.ToInt32(Console.ReadLine());

            int decimalB = binaryDecimal(binary);
            Console.WriteLine("El numero binario " + binary + " en decimal es " + decimalB);

            Console.ReadLine();
        }

        public static int binaryDecimal(long binary)
        {

            int numero = 0;
            int digit = 0;
            const int divisor = 10;

            for (long i = binary, n = 0; i > 0; i /= divisor, n++)
            {
                digit = (int)i % divisor;
                if (digit != 1 && digit != 0)
                {
                    return -1;
                }
                numero += digit * (int)Math.Pow(2, n);
            }

            return numero;
        }
    }
}



