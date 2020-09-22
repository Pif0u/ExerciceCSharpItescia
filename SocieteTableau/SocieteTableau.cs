using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteTableau
{
    class SocieteTableau
    {
        static void Main(string[] args)
        {
            var employe1 = new Employe("Liane", "Beaujolie", 18, 1000);
            var employe2 = new Employe("Onfroi ", "Baron", 22, 2000);
            var employe3 = new Employe("Orlene ", "Ratté", 1500);
            var employe4 = new Employe("Felicien ", "Cinq-Mars", 26, 1250);
            var employe5 = new Employe("Madeleine ", "Leclair", 1900);

            var chef1 = new Chef("Édith", "Camus", 3000, "Informatique");
            var chef2 = new Chef("Solaine", "Laframboise",45,  3000, "Informatique");

            var directeur = new Directeur("Somerville", "Marquis", 4000, "Direction", "Facebook");


            var tableauArticle = new[]
                {employe1, employe2, employe3, employe4, employe5, chef1, chef2, directeur};

            Console.WriteLine("[Parcours de tous les employés avec FOR]");
            for (int i = 0; i < tableauArticle.Length; i++)
            {
                tableauArticle[i].Afficher();
                Console.WriteLine(Environment.NewLine);
            }

            employe2.Age++;

            chef1.Salaire = 3500;
            chef1.Service = "Comptable";


            Console.WriteLine("[Parcours de tous les employés avec FOREACH]");
            foreach (var employe in tableauArticle)
            {
                employe.Afficher();
                Console.WriteLine(Environment.NewLine);

            }


        }
    }
}
