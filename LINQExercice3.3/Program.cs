using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercice3._3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var listeEntiers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var listeNombreDivisiblePar5 =
                listeEntiers.Where(valeur => valeur % 5 == 0).ToList();

            Console.WriteLine("Liste des nombres divisible par 5");
            foreach (int val in listeNombreDivisiblePar5)
            {
                Console.Write(val + " ");
            }
        }
    }
}