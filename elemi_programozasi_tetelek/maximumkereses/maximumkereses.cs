using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static double Maximum(List<double> lista)
        {
            double max = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (max < lista[i])
                {
                    max = lista[i];
                }
            }
            return max;
        }

        static int Maximum_indexe(List<double> lista)
        {
            double max = lista[0];
            int maxi = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (max < lista[i])
                {
                    max = lista[i];
                    maxi = i;
                }
            }
            return maxi;
        }

        static void Main(string[] args)
        {
            List<double> l = new List<double> { 4, 5, 3, 2, 1};
            Console.WriteLine(Maximum(l));
            Console.WriteLine(Maximum_indexe(l));
        }
    }
}
