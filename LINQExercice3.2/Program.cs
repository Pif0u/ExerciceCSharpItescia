using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercice3._2
{
    class Program
    {

        private static void Main(string[] args)
        {
            var listeAnnees = new List<int> { 2004, 2005, 2016, 2020, 2002 };

            var annees =
                from uneAnnee in listeAnnees
                where DateTime.IsLeapYear(uneAnnee)
                select uneAnnee;

            var nbrValeurs = annees.Count();
            if (nbrValeurs == 0)
            {
                Console.WriteLine("Aucune années bissextiles");
            }
            else
            {
                Console.WriteLine("Liste des années bissextiles");
                var listeAnneesBissextiles = annees.ToList();
                foreach (var anneesBissextile in listeAnneesBissextiles) Console.Write(anneesBissextile + " ");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}
