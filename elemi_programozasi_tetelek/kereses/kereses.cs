using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Helye1(List<double> lista)
        {
            int i = 0;
            while (i < lista.Count && !(lista[i] < 0))
            {
                i++;
            }
            return i;
        }

        static int Helye2(List<double> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i]<0)
                {
                    return i;
                }
            }
            return lista.Count;
        }

        static int Keres(List<double> lista)
        {
            int h = Helye1(lista);
            return h == lista.Count ? -1 : h;
        }

        static bool Eldontes(List<double> lista) => Helye1(lista) != lista.Count;

        static void Main(string[] args)
        {
            List<double> lvan = new List<double> { 4, 5, 3, -2, 1 };
            List<double> lnincs = new List<double> { 4, 5, 3, 2, 1 };

            Console.WriteLine(Helye1(lvan));
            Console.WriteLine(Helye1(lnincs));
            Console.WriteLine(Helye2(lvan));
            Console.WriteLine(Helye2(lnincs));
            Console.WriteLine(Keres(lvan));
            Console.WriteLine(Keres(lnincs));
            Console.WriteLine(Eldontes(lvan));
            Console.WriteLine(Eldontes(lnincs));
            Console.WriteLine(lvan.FindIndex(x => x < 0));
            Console.WriteLine(lnincs.FindIndex(x => x < 0));
        }
    }
}
