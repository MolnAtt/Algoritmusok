using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<double> Masolas1(List<double> lista)
        {
            List<double> result = new List<double>(lista.Count); // így kerülhető el a sok resize!
            foreach (double elem in lista)
            {
                result.Add(elem * elem);
            }
            return result;
        }

        static double[] Masolas2(double[] tomb)
        {
            double[] result = new double[tomb.Length];
            for (int i = 0; i < tomb.Length; i++)
            {
                result[i] = tomb[i] * tomb[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<double> l = new List<double> { 4, 5, 3, 2, 1 };
            foreach (double elem in Masolas1(l))
            {
                Console.Write(elem);
                Console.Write(" ");
            }
            Console.WriteLine();
            foreach (double elem in Masolas2(l.ToArray()))
            {
                Console.Write(elem);
                Console.Write(" ");
            }

        }
    }
}
