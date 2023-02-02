using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static double Osszeg1(List<double> lista)
        {
            double sum = 0;
            foreach (double elem in lista)
            {
                sum += elem;
            }
            return sum;
        }
        static double Osszeg2(List<double> lista)
        {
            double sum = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                sum += lista[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            List<double> l = new List<double> { 1, 2, 3, 4, 5};
            Console.WriteLine(Osszeg1(l));
            Console.WriteLine(Osszeg2(l));
        }
    }
}
