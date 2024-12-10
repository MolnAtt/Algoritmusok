using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<double> Kivalogat(List<double> lista)
        {
            List<double> result = new List<double>();
            foreach (double elem in lista)
            {
                if (0<elem)
                {
                    result.Add(elem);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<double> l = new List<double> { -4, 5, -3, -2, 1};
            foreach (double elem in Kivalogat(l))
            {
                Console.Write(elem);
                Console.Write(" ");
            }
            Console.WriteLine();

            // erre van beépített Linq
            foreach (double elem in l.Where(x => 0<x)) 
            {
                Console.Write(elem);
                Console.Write(" ");
            }

        }
    }
}
