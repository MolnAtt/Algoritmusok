using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Megszamolas(List<double> lista)
        {
            int db = 0;
            foreach (double elem in lista)
            {
                db++;
            }
            return db;
        }

        static void Main(string[] args)
        {
            List<double> l = new List<double> { 4, 5, 3, 2, 1};
            Console.WriteLine(l.Count);
            Console.WriteLine(Megszamolas(l));
        }
    }
}
