using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercice3._1
{
    internal class Program
    {
        private static bool NombreEntier(int nombre)
        {
            if (nombre < 2) return false;

            if (nombre == 2) return true;

            if (nombre % 2 == 0) return false;

            for (var i = 3; i * i <= nombre; i += 2)
                if (nombre % i == 0)
                    return false;

            return true;
        }


        private static void Main(string[] args)
        {
            var listeEntiers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var premiers =
                from unEntier in listeEntiers
                where NombreEntier(unEntier)
                select unEntier;

            var nbrValeurs = premiers.Count();
            if (nbrValeurs == 0)
            {
                Console.WriteLine("Aucun nombre premiers");
            }
            else
            {
                Console.WriteLine("Liste des nombres premiers");
                var listeNombrePremiers = premiers.ToList();
                foreach (var nombrePremier in listeNombrePremiers) Console.Write(nombrePremier + " ");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}