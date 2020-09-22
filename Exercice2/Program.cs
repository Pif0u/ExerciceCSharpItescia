using System;
using System.Collections.Generic;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de deux articles directement depuis le code source
            Article article1 = new Article("PS5", 499.99, 5);
            Article article2 = new Article("Xbox Series X", 499.99, 8);

            article1.Afficher();
            article2.Afficher();

            article1.Ajouter();
            article2.Retirer();

            article1.Afficher();
            article2.Afficher();


            // Création d'un article par l'utilisateur
            Console.WriteLine("[Creation d'un nouveau article]");
            Console.WriteLine("Nom de l'article : ");
            string nomNewArticle = Console.ReadLine();
            Console.WriteLine("Prix de l'article");
            double prixNewArticle;
            while (!double.TryParse(Console.ReadLine(), out prixNewArticle))
            {
                Console.WriteLine("Erreur : Format du prix incorrect");
            };
            Console.WriteLine("Quantité de l'article");
            int quaniteNewArticle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            Article newArticle = new Article(nomNewArticle, prixNewArticle, quaniteNewArticle);


            newArticle.Afficher();




        }
    }
}
