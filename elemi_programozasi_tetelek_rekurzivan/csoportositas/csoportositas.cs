using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static Dictionary<char, List<string>> Csoportosit(List<string> lista)
        {
            Dictionary<char, List<string>> szotar = new Dictionary<char, List<string>>();
            foreach (string elem in lista)
            {
                char kulcs = elem[0];
                if (szotar.Keys.Contains(kulcs))
                {
                    szotar[kulcs].Add(elem);
                }
                else
                {
                    szotar[kulcs] = new List<string> { elem };
                }
            }
            return szotar;
        }

        static void Main(string[] args)
        {
            List<string> szavak = new List<string> { "répa", "retek", "mogyoró", "korán", "reggel", "ritkán", "rikkant", "a", "rigó"};

            Dictionary<char, List<string>> szotar = Csoportosit(szavak);
            foreach (char kulcs in szotar.Keys)
            {
                Console.Write(kulcs);
                Console.Write(": ");
                Console.WriteLine(string.Join(", ", szotar[kulcs]));
            }
        }
    }
}
