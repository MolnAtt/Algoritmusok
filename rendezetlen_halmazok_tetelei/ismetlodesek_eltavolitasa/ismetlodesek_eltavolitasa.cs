using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {

        static List<double> Ismetlodesmentes1(List<double> lista)
        {
            List<double> result = new List<double>();
            foreach (double elem in lista)
            {
                if (!result.Contains(elem))
                {
                    result.Add(elem);
                }
            }
            return result;
        }

        static List<double> Ismetlodesmentes2(List<double> lista)
        {
            List<double> rendezett= new List<double>(lista);
            if (lista.Count < 2)
            {
                return rendezett;
            }

            rendezett.Sort();

            List<double> result = new List<double>(rendezett.Count);
            result.Add(rendezett[0]);

            for (int i = 1; i < rendezett.Count; i++)
            {
                if (rendezett[i-1] != rendezett[i])
                {
                    result.Add(rendezett[i]);
                }
            }

            return result;
        }

        static List<double> Ismetlodesmentes3(List<double> lista) => lista.ToHashSet().ToList();
        static List<double> Ismetlodesmentes4(List<double> lista) => lista.Distinct().ToList();

        static void Main(string[] args)
        {
            List<double> l = new List<double> {5, 5, 3, 2, 3, 4, 5, 6, 6, 5, 5, 5, 3, 2};
            Console.WriteLine(string.Join(", ", Ismetlodesmentes1(l)));
            Console.WriteLine(string.Join(", ", Ismetlodesmentes2(l)));
            Console.WriteLine(string.Join(", ", Ismetlodesmentes3(l)));
            Console.WriteLine(string.Join(", ", Ismetlodesmentes4(l)));
        }
    }
}
