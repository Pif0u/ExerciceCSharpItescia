using System;
using System.Collections.Generic;
using System.Text;
using SocieteEnumeration.ListeChainee;
using SocieteEnumeration.Societe;

namespace SocieteEnumeration
{
    class GererSocieteEnumeration
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

            var ListeEnumeration = new ListeEnumeration(Liste);



        }
    }
}