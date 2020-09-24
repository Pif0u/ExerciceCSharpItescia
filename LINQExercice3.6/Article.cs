using System;
using System.Collections.Generic;
using System.Text;

namespace LINQExercice3._6
{
    public class Article
    {
        public string nomArticle;
        public double prixArticle;
        public int quantiteArticle;

        public Article(string nomArticle, double prixArticle, int quantiteArticle)
        {
            this.nomArticle = nomArticle;
            this.prixArticle = prixArticle;
            this.quantiteArticle = quantiteArticle;
        }


        public void Afficher()
        {
            Console.WriteLine("[Affichage Article]");
            Console.WriteLine("Nom de l'article : " + nomArticle);
            Console.WriteLine("Prix de l'article : " + prixArticle + " euros");
            Console.WriteLine("Quantité de l'Article : " + quantiteArticle);
            Console.WriteLine(Environment.NewLine);
        }

        public void Ajouter()
        {
            quantiteArticle++;
            Console.WriteLine("[Ajout Article]");
            Console.WriteLine("Vous avez ajouter un article, il y a donc " + quantiteArticle + " unité de l'article " + nomArticle);
            Console.WriteLine(Environment.NewLine);
        }

        public void Retirer()
        {
            if (quantiteArticle != 0)
            {
                quantiteArticle--;
                Console.WriteLine("[Suppression Article]");
                Console.WriteLine("Vous avez supprimez un article, il reste " + quantiteArticle + " unité de l'article " + nomArticle);
                Console.WriteLine(Environment.NewLine);
            }
            else
            {
                Console.WriteLine("[Suppression Article]");
                Console.WriteLine("Erreur : Il y a déjà 0 article");
                Console.WriteLine(Environment.NewLine);
            }

        }



    }

}
