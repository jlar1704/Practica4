using System;
using System.Collections.Generic;

namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.Write("Numeros Pares = ");
            numeros.Pares().ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();

            //Parte 2
            Console.WriteLine("\nesImpar(5) = {0} \n", esImpar(5));
            Console.WriteLine("CalcularITBIS(5000) = {0} \n", CalcularITBIS(5000));
            Console.WriteLine("GetDate() = {0}", GetDate());
        }

        public static bool esImpar(int numero)
        {
            return (numero % 2 != 0);
        }

        public static double CalcularITBIS(double valor)
        {
            return (valor * 0.18);
        }

        public static DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
