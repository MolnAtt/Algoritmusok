using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {

        static List<double> Ismetlodesmentes(List<double> lista)
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



        static List<double> IsmetlodesmentesRendezettListabol(List<double> rlista)
        {

            if (rlista.Count<2)
            {
                return new List<double>(rlista);
            }

            List<double> result = new List<double>(rlista.Count);

            result.Add(rlista[0]);
            for (int i = 1; i < rlista.Count; i++)
            {
                if (rlista[i - 1] != rlista[i])
                {
                    result.Add(rlista[i]);
                }
            }

            return result;
        }
        static List<double> RendezettIsmetlodesmentes(List<double> lista)
        {
            List<double> rlista = new List<double>(lista);
            rlista.Sort();
            return IsmetlodesmentesRendezettListabol(rlista);
        }

        static List<double> Ismetlodesmentes3(List<double> lista) => lista.ToHashSet().ToList();
        static List<double> Ismetlodesmentes4(List<double> lista) => lista.Distinct().ToList();

        static void Main(string[] args)
        {
            List<double> l = new List<double> {5, 5, 3, 2, 3, 4, 5, 6, 6, 5, 5, 5, 3, 2};
            Console.WriteLine(string.Join(", ", Ismetlodesmentes(l)));
            Console.WriteLine(string.Join(", ", RendezettIsmetlodesmentes(l)));
            Console.WriteLine(string.Join(", ", Ismetlodesmentes3(l)));
            Console.WriteLine(string.Join(", ", Ismetlodesmentes4(l)));
        }
    }
}
