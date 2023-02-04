using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Elsoi(List<double> lista)
        {
            int i = 0;
            while (!(lista[i] < 0))
            {
                i++;
            }
            return i;
        }

        static double Elso1(List<double> lista) => lista[Elsoi(lista)];

        static double Elso2(List<double> lista)
        {
            foreach (double elem in lista)
            {
                if (elem < 0)
                {
                    return elem;
                }
            }
            return -1; // Ha az előfeltétel teljesül, ez elérhetetlen.
        }

        static void Main(string[] args)
        {
            List<double> l = new List<double> { 4, 5, 3, -2, 1 };

            Console.WriteLine(Elsoi(l));
            Console.WriteLine(Elso1(l));
            Console.WriteLine(Elso2(l));
            Console.WriteLine(l.First(x => x < 0));
        }
    }
}
