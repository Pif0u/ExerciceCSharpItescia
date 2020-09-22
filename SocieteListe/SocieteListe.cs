using System;
using System.Collections.Generic;
using System.Text;
using SocieteListe.ListeChainee;
using SocieteListe.Societe;

namespace SocieteListe
{
    class GererSocieteListe
    {
        static void Main(string[] args)
        {
            var employe1 = new Employe("Liane", "Beaujolie", 18, 1000);
            var employe2 = new Employe("Onfroi ", "Baron", 22, 2000);
            var employe3 = new Employe("Orlene ", "Ratté", 1500);
            var employe4 = new Employe("Felicien ", "Cinq-Mars", 26, 1250);
            var employe5 = new Employe("Madeleine ", "Leclair", 1900);

            var chef1 = new Chef("Édith", "Camus", 3000, "Informatique");
            var chef2 = new Chef("Solaine", "Laframboise", 45, 3000, "Informatique");

            var directeur = new Directeur("Somerville", "Marquis", 4000, "Direction", "Facebook");

            var Liste = new Liste();
            Liste.InsererDebut(employe1);
            Liste.InsererDebut(employe2);
            Liste.InsererDebut(employe3);
            Liste.InsererDebut(employe4);
            Liste.InsererDebut(employe5);
            Liste.InsererDebut(chef1);
            Liste.InsererDebut(chef2);
            Liste.InsererDebut(directeur);


            Console.WriteLine(" -- [Affichage avec InsererDebut] --");
            Liste.Lister();

            Console.WriteLine("-- Vidage Liste --");
            Liste.Vider();

            
            Liste.InsererFin(employe1);
            Liste.InsererFin(employe2);
            Liste.InsererFin(employe3);
            Liste.InsererFin(employe4);
            Liste.InsererFin(employe5);
            Liste.InsererFin(chef1);
            Liste.InsererFin(chef2);
            Liste.InsererFin(directeur);

            Console.WriteLine(" -- [Affichage avec InsererFin] --");
            Liste.Lister();

            Console.WriteLine(" -- [Affichage avec Indexeurs] --");
            Console.WriteLine(Liste.Get(1).ToString());



        }

    }
}
