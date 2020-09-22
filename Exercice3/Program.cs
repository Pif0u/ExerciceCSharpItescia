using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de deux articles directement depuis le code source
            ArticleType article1 = new ArticleType("PS5", 499.99, 5, TypeArticleEnum.Loisir);
            ArticleType article2 = new ArticleType("Jus d'" + "orange", 1.50, 25, TypeArticleEnum.Alimentaire);

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
            Console.WriteLine("Type de l'article : ");
            Console.WriteLine("1. Alimentaire ");
            Console.WriteLine("2. Droguerie");
            Console.WriteLine("3. Habillement");
            Console.WriteLine("4. Loisir : ");

            TypeArticleEnum typeNewArticle = (TypeArticleEnum)(Convert.ToInt32(Console.ReadLine()) - 1);


            ArticleType newArticle = new ArticleType(nomNewArticle, prixNewArticle, quaniteNewArticle, typeNewArticle);

            Console.WriteLine(Environment.NewLine);

            newArticle.Afficher();




        }
    }
}
