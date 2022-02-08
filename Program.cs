using System;

namespace Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter U Number: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            long bin = 0;
            const int divisor = 2;
            long dig = 0;

            for (int contador = numero % divisor, contador2 = 0; numero > 0; numero /= divisor, contador = numero % divisor, contador2++)
            {
                dig = contador % divisor;
                bin += dig * (long)Math.Pow(10, contador2);
            }
            Console.WriteLine(bin);
        }
    }
}
